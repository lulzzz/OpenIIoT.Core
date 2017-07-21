﻿using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web.Http;
using Newtonsoft.Json;
using NLog;
using OpenIIoT.Core.Platform;
using OpenIIoT.Core.Plugin;
using OpenIIoT.SDK;
using OpenIIoT.SDK.Common;
using Utility.OperationResult;
using OpenIIoT.SDK.Package;
using OpenIIoT.Core.Service.WebAPI;
using System.IO;

namespace OpenIIoT.Core.Package.WebAPI
{
    /// <summary>
    ///     Handles the API methods for AppPackages.
    /// </summary>
    public class PackageController : ApiBaseController
    {
        #region Variables

        /// <summary>
        ///     The Logger for this class.
        /// </summary>
        private static Logger logger = LogManager.GetCurrentClassLogger();

        /// <summary>
        ///     The default serialization properties for an AppPackage.
        /// </summary>
        private static List<string> pluginPackageSerializationProperties = new List<string>(new string[] { "Files" });

        /// <summary>
        ///     The ApplicationManager for the application.
        /// </summary>
        private IApplicationManager manager = ApplicationManager.GetInstance();

        #endregion Variables

        #region Instance Methods

        [Route("api/package/{fqn}/delete")]
        [HttpGet]
        public async Task<HttpResponseMessage> DeletePackage(string fqn)
        {
            HttpResponseMessage retVal;
            HttpStatusCode statusCode = HttpStatusCode.OK;

            IResult deleteResult = await manager.GetManager<IPackageManager>().DeletePackageAsync(fqn);

            retVal = Request.CreateResponse(HttpStatusCode.OK, deleteResult, JsonFormatter());
            return retVal;
        }

        [Route("api/package/{fqn}/download")]
        [HttpGet]
        public async Task<HttpResponseMessage> DownloadPackage(string fqn)
        {
            HttpResponseMessage retVal;

            IPackage findResult = await manager.GetManager<IPackageManager>().FindPackageAsync(fqn);

            if (findResult != default(IPackage))
            {
                string packageFile = findResult.FileName;

                retVal = new HttpResponseMessage(HttpStatusCode.OK);

                retVal.Content = new StreamContent(new FileStream(packageFile, FileMode.Open, FileAccess.Read));
                retVal.Content.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");
                retVal.Content.Headers.ContentDisposition = new ContentDispositionHeaderValue("attachment") { FileName = Path.GetFileName(packageFile) };
            }
            else
            {
                retVal = Request.CreateResponse(HttpStatusCode.NotFound, findResult, JsonFormatter());
            }

            return retVal;
        }

        /// <summary>
        ///     Returns the Package from the list of available Packages that matches the supplied Fully Qualified Name.
        /// </summary>
        /// <param name="fqn">The Fully Qualified Name of the Package to return.</param>
        /// <returns>The matching Package.</returns>
        [Route("api/package/{fqn}")]
        [HttpGet]
        public async Task<HttpResponseMessage> FindPackage(string fqn)
        {
            HttpResponseMessage retVal;
            IPackage findResult = await manager.GetManager<IPackageManager>().FindPackageAsync(fqn);

            retVal = Request.CreateResponse(HttpStatusCode.OK, findResult, JsonFormatter(ContractResolverType.OptOut, "Files"));

            return retVal;
        }

        [Route("api/package")]
        [HttpGet]
        public HttpResponseMessage GetPackages()
        {
            IList<IPackage> packages = manager.GetManager<IPackageManager>().Packages;

            return Request.CreateResponse(HttpStatusCode.OK, packages, JsonFormatter(ContractResolverType.OptOut, "Files"));
        }

        [Route("api/package/{fqn}/install")]
        [HttpGet]
        public async Task<HttpResponseMessage> InstallPackage(string fqn, string publicKey = "")
        {
            IResult installResult = await manager.GetManager<IPackageManager>().InstallPackageAsync(fqn, publicKey);

            return Request.CreateResponse(HttpStatusCode.OK, installResult, JsonFormatter());
        }

        [Route("api/package/{fqn}/install/overwrite")]
        [HttpGet]
        public async Task<HttpResponseMessage> InstallPackageOverwrite(string fqn, string publicKey = "")
        {
            IResult installResult = await manager.GetManager<IPackageManager>().InstallPackageAsync(fqn, PackageInstallOptions.Overwrite, publicKey);

            return Request.CreateResponse(HttpStatusCode.OK, installResult, JsonFormatter());
        }

        [Route("api/package/{fqn}/install/overwrite/skipverification")]
        [HttpGet]
        public async Task<HttpResponseMessage> InstallPackageOverwriteSkipVerification(string fqn, string publicKey = "")
        {
            PackageInstallOptions options = PackageInstallOptions.Overwrite | PackageInstallOptions.SkipVerification;
            IResult installResult = await manager.GetManager<IPackageManager>().InstallPackageAsync(fqn, options, publicKey);

            return Request.CreateResponse(HttpStatusCode.OK, installResult, JsonFormatter());
        }

        [Route("api/package/{fqn}/install/skipverification")]
        [HttpGet]
        public async Task<HttpResponseMessage> InstallPackageSkipVerification(string fqn, string publicKey = "")
        {
            IResult installResult = await manager.GetManager<IPackageManager>().InstallPackageAsync(fqn, PackageInstallOptions.SkipVerification, publicKey);

            return Request.CreateResponse(HttpStatusCode.OK, installResult, JsonFormatter());
        }

        [Route("api/package/save")]
        [HttpPost]
        [ImportFileParamType.SwaggerFormAttribute("ImportImage", "Upload image file")]
        public async Task<HttpResponseMessage> SavePacakge()
        {
            // Check if the request contains multipart/form-data.
            if (!Request.Content.IsMimeMultipartContent())
            {
                throw new HttpResponseException(HttpStatusCode.UnsupportedMediaType);
            }

            string root = System.Web.HttpContext.Current.Server.MapPath("~/App_Data");
            var provider = new MultipartFormDataStreamProvider(root);

            try
            {
                // Read the form data.
                await Request.Content.ReadAsMultipartAsync(provider);

                // This illustrates how to get the file names.
                foreach (MultipartFileData file in provider.FileData)
                {
                    logger.Info(file.Headers.ContentDisposition.FileName);
                    logger.Info("Server file path: " + file.LocalFileName);
                }
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (System.Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e);
            }
        }

        /// <summary>
        ///     Reloads the list of Packages from disk and returns the list.
        /// </summary>
        /// <returns>The reloaded list of available Packages.</returns>
        [Route("api/package/scan")]
        [HttpGet]
        public async Task<HttpResponseMessage> ScanPackages()
        {
            IResult<IList<IPackage>> packages = await manager.GetManager<IPackageManager>().ScanPackagesAsync();

            return Request.CreateResponse(HttpStatusCode.OK, packages, JsonFormatter(ContractResolverType.OptOut, "Files"));
        }

        [Route("api/package/{fqn}/verify")]
        [HttpGet]
        public async Task<HttpResponseMessage> VerifyPackage(string fqn, string publicKey = "")
        {
            IResult<bool> verifyResult = await manager.GetManager<IPackageManager>().VerifyPackageAsync(fqn, publicKey);

            return Request.CreateResponse(HttpStatusCode.OK, verifyResult, JsonFormatter());
        }

        #endregion Instance Methods
    }
}