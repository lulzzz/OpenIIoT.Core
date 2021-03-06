﻿/*
      █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀ ▀▀▀▀▀▀▀▀▀▀▀▀▀▀ ▀▀▀  ▀  ▀      ▀▀
      █
      █     ▄████████                                                                       ▄█    █▄
      █     ███    ███                                                                     ███    ███
      █     ███    ███    █████    ▄████▄  ██   █     ▄▄██▄▄▄     ▄█████ ██▄▄▄▄      ██    ███    ███   ▄█████   █        █  ██████▄    ▄█████      ██     ██████     █████
      █     ███    ███   ██  ██   ██    ▀  ██   ██  ▄█▀▀██▀▀█▄   ██   █  ██▀▀▀█▄ ▀███████▄ ███    ███   ██   ██ ██       ██  ██   ▀██   ██   ██ ▀███████▄ ██    ██   ██  ██
      █   ▀███████████  ▄██▄▄█▀  ▄██       ██   ██  ██  ██  ██  ▄██▄▄    ██   ██     ██  ▀ ███    ███   ██   ██ ██       ██▌ ██    ██   ██   ██     ██  ▀ ██    ██  ▄██▄▄█▀
      █     ███    ███ ▀███████ ▀▀██ ███▄  ██   ██  ██  ██  ██ ▀▀██▀▀    ██   ██     ██    ███    ███ ▀████████ ██       ██  ██    ██ ▀████████     ██    ██    ██ ▀███████
      █     ███    ███   ██  ██   ██    ██ ██   ██  ██  ██  ██   ██   █  ██   ██     ██     ██▄  ▄██    ██   ██ ██▌    ▄ ██  ██   ▄██   ██   ██     ██    ██    ██   ██  ██
      █     ███    █▀    ██  ██   ██████▀  ██████    █  ██  █    ███████  █   █     ▄██▀     ▀████▀     ██   █▀ ████▄▄██ █   ██████▀    ██   █▀    ▄██▀    ██████    ██  ██
      █
 ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄ ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄ ▄▄  ▄▄ ▄▄   ▄▄▄▄ ▄▄     ▄▄     ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄ ▄ ▄
 █████████████████████████████████████████████████████████████ ███████████████ ██  ██ ██   ████ ██     ██     ████████████████ █ █
      ▄
      █  Contains methods used to validate arguments for packaging operations.
      █
      █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀ ▀▀▀▀▀▀▀▀▀▀▀ ▀ ▀▀▀     ▀▀               ▀
      █  The GNU Affero General Public License (GNU AGPL)
      █
      █  Copyright (C) 2016-2017 JP Dillingham (jp@dillingham.ws)
      █
      █  This program is free software: you can redistribute it and/or modify
      █  it under the terms of the GNU Affero General Public License as published by
      █  the Free Software Foundation, either version 3 of the License, or
      █  (at your option) any later version.
      █
      █  This program is distributed in the hope that it will be useful,
      █  but WITHOUT ANY WARRANTY; without even the implied warranty of
      █  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
      █  GNU Affero General Public License for more details.
      █
      █  You should have received a copy of the GNU Affero General Public License
      █  along with this program.  If not, see <http://www.gnu.org/licenses/>.
      █
      ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀  ▀▀ ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀██
                                                                                                   ██
                                                                                               ▀█▄ ██ ▄█▀
                                                                                                 ▀████▀
                                                                                                   ▀▀                            */

namespace OpenIIoT.SDK.Packaging.Operations
{
    using System;
    using System.IO;
    using OpenIIoT.SDK.Common;

    /// <summary>
    ///     Contains methods used to validate arguments for packaging operations.
    /// </summary>
    internal static class ArgumentValidator
    {
        #region Internal Methods

        /// <summary>
        ///     Validates the inputDirectory argument for packaging operations.
        /// </summary>
        /// <param name="inputDirectory">The value specified for the inputDirectory argument.</param>
        /// <exception cref="ArgumentException">Thrown when the directory is an empty or null string.</exception>
        /// <exception cref="DirectoryNotFoundException">
        ///     Thrown when the directory can not be found on the local file system.
        /// </exception>
        /// <exception cref="FileNotFoundException">Thrown when the directory contains no files.</exception>
        internal static void ValidateInputDirectoryArgument(string inputDirectory)
        {
            if (string.IsNullOrEmpty(inputDirectory))
            {
                throw new ArgumentException($"The required argument 'directory' was not supplied.");
            }

            if (!Directory.Exists(inputDirectory))
            {
                throw new DirectoryNotFoundException($"The specified directory '{inputDirectory}' could not be found.");
            }

            if (Directory.GetFiles(inputDirectory, "*", SearchOption.AllDirectories).Length == 0)
            {
                throw new FileNotFoundException($"The specified directory '{inputDirectory}' is empty; Packages must contain at least one file.");
            }
        }

        /// <summary>
        ///     Validates the outputDirectory and overwrite arguments for packaging operations.
        /// </summary>
        /// <param name="outputDirectory">The value specified for the outputDirectory argument.</param>
        /// <param name="overwrite">The value specified for the overwrite argument.</param>
        /// <exception cref="ArgumentException">Thrown when the package is an empty or null string.</exception>
        /// <exception cref="InvalidOperationException">
        ///     Thrown when the output directory exists and is not empty but the overwrite argument is false.
        /// </exception>
        internal static void ValidateOutputDirectoryArgument(string outputDirectory, bool overwrite = false)
        {
            if (string.IsNullOrEmpty(outputDirectory))
            {
                throw new ArgumentException("The required argument 'directory' was not supplied.");
            }

            if (Directory.Exists(outputDirectory) && !overwrite)
            {
                if (Directory.GetFiles(outputDirectory).Length > 0)
                {
                    throw new InvalidOperationException($"The directory '{outputDirectory}' exists and is not empty.");
                }
            }
        }

        /// <summary>
        ///     Validates the packageFile argument for packaging operations which read the specified Package.
        /// </summary>
        /// <param name="packageFile">The value specified for the packageFile argument.</param>
        /// <exception cref="ArgumentException">Thrown when the package is an empty or null string.</exception>
        /// <exception cref="FileNotFoundException">Thrown when the package can not be found on the local file system.</exception>
        /// <exception cref="InvalidDataException">Thrown when the package contains no files.</exception>
        /// <exception cref="IOException">Thrown when the package can not be read.</exception>
        internal static void ValidatePackageFileArgumentForReading(string packageFile)
        {
            if (string.IsNullOrEmpty(packageFile))
            {
                throw new ArgumentException($"The required argument 'package' was not supplied.");
            }

            if (!File.Exists(packageFile))
            {
                throw new FileNotFoundException($"The specified package file '{packageFile}' could not be found.");
            }

            if (new FileInfo(packageFile).Length == 0)
            {
                throw new InvalidDataException($"The specified package file '{packageFile}' is empty.");
            }

            FileStream packageStream = default(FileStream);

            try
            {
                packageStream = File.OpenRead(packageFile);
            }
            catch (Exception ex)
            {
                throw new IOException($"The specified package file '{packageFile}' could not be opened for reading: {ex.Message}");
            }
            finally
            {
                packageStream?.Close();
            }
        }

        /// <summary>
        ///     Validates the packageFile argument for packaging operations which write the specified Package.
        /// </summary>
        /// <param name="packageFile">The value specified for the packageFile argument.</param>
        /// <param name="overwrite">A value indicating whether the specified package is to be overwritten if it exists.</param>
        /// <exception cref="ArgumentException">Thrown when the package is an empty or null string.</exception>
        /// <exception cref="InvalidOperationException">Thrown when the package exists and the overwrite option is false.</exception>
        /// <exception cref="FileNotFoundException">Thrown when the package can not be found on the local file system.</exception>
        /// <exception cref="InvalidDataException">Thrown when the package contains no files.</exception>
        /// <exception cref="IOException">Thrown when the package can not be read.</exception>
        internal static void ValidatePackageFileArgumentForWriting(string packageFile, bool overwrite = false)
        {
            if (string.IsNullOrEmpty(packageFile))
            {
                throw new ArgumentException($"The required argument 'package' was not supplied.");
            }

            if (!overwrite && File.Exists(packageFile))
            {
                throw new InvalidOperationException($"The specified package file '{packageFile}' already exists.");
            }
        }

        /// <summary>
        ///     Validates the privateKeyFile and passphrase arguments for packaging operations.
        /// </summary>
        /// <param name="privateKey">The value specified for the privateKeyFile argument.</param>
        /// <param name="passphrase">the value specified for the privateKeyPassphrase argument.</param>
        /// <exception cref="ArgumentException">
        ///     Thrown when the privateKeyFile, privateKeyPassword, or publicKeyFile arguments are a default or null string.
        /// </exception>
        internal static void ValidatePrivateKeyArguments(string privateKey, string passphrase)
        {
            if (string.IsNullOrEmpty(privateKey))
            {
                throw new ArgumentException("The required argument 'private key' was not supplied.");
            }
            else if (string.IsNullOrEmpty(passphrase))
            {
                throw new ArgumentException("The required argument 'passphrase' was not supplied.");
            }
        }

        #endregion Internal Methods
    }
}