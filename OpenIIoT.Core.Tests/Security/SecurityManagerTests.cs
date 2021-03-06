﻿/*
      █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀ ▀▀▀▀▀▀▀▀▀▀▀▀▀▀ ▀▀▀  ▀  ▀      ▀▀
      █
      █      ▄████████                                                              ▄▄▄▄███▄▄▄▄
      █     ███    ███                                                            ▄██▀▀▀███▀▀▀██▄
      █     ███    █▀     ▄█████  ▄██████ ██   █     █████  █      ██    ▄█   ▄   ███   ███   ███   ▄█████  ██▄▄▄▄    ▄█████     ▄████▄     ▄█████    █████
      █     ███          ██   █  ██    ██ ██   ██   ██  ██ ██  ▀███████▄ ██   █▄  ███   ███   ███   ██   ██ ██▀▀▀█▄   ██   ██   ██    ▀    ██   █    ██  ██
      █   ▀███████████  ▄██▄▄    ██    ▀  ██   ██  ▄██▄▄█▀ ██▌     ██  ▀ ▀▀▀▀▀██  ███   ███   ███   ██   ██ ██   ██   ██   ██  ▄██        ▄██▄▄     ▄██▄▄█▀
      █            ███ ▀▀██▀▀    ██    ▄  ██   ██ ▀███████ ██      ██    ▄█   ██  ███   ███   ███ ▀████████ ██   ██ ▀████████ ▀▀██ ███▄  ▀▀██▀▀    ▀███████
      █      ▄█    ███   ██   █  ██    ██ ██   ██   ██  ██ ██      ██    ██   ██  ███   ███   ███   ██   ██ ██   ██   ██   ██   ██    ██   ██   █    ██  ██
      █    ▄████████▀    ███████ ██████▀  ██████    ██  ██ █      ▄██▀    █████    ▀█   ███   █▀    ██   █▀  █   █    ██   █▀   ██████▀    ███████   ██  ██
      █
      █       ███
      █   ▀█████████▄
      █      ▀███▀▀██    ▄█████   ▄█████     ██      ▄█████
      █       ███   ▀   ██   █    ██  ▀  ▀███████▄   ██  ▀
      █       ███      ▄██▄▄      ██         ██  ▀   ██
      █       ███     ▀▀██▀▀    ▀███████     ██    ▀███████
      █       ███       ██   █     ▄  ██     ██       ▄  ██
      █      ▄████▀     ███████  ▄████▀     ▄██▀    ▄████▀
      █
 ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄ ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄ ▄▄  ▄▄ ▄▄   ▄▄▄▄ ▄▄     ▄▄     ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄ ▄ ▄
 █████████████████████████████████████████████████████████████ ███████████████ ██  ██ ██   ████ ██     ██     ████████████████ █ █
      ▄
      █  Unit tests for the SecurityManager class.
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

namespace OpenIIoT.Core.Tests.Security
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Security.Claims;
    using Moq;
    using OpenIIoT.Core.Security;
    using OpenIIoT.SDK;
    using OpenIIoT.SDK.Common;
    using OpenIIoT.SDK.Common.Exceptions;
    using OpenIIoT.SDK.Common.OperationResult;
    using OpenIIoT.SDK.Configuration;
    using OpenIIoT.SDK.Security;
    using Xunit;

    /// <summary>
    ///     Unit tests for the <see cref="SecurityManager"/> class.
    /// </summary>
    public class SecurityManagerTests
    {
        #region Public Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="SecurityManagerTests"/> class.
        /// </summary>
        public SecurityManagerTests()
        {
            SetupMocks();

            SecurityManager.Terminate();

            Manager = SecurityManager.Instantiate(ApplicationManager.Object, ConfigurationManager.Object);
        }

        #endregion Public Constructors

        #region Private Properties

        /// <summary>
        ///     Gets or sets the <see cref="IConfiguration"/> mockup for the unit tests.
        /// </summary>
        private Mock<IConfiguration> ApplicationConfiguration { get; set; }

        /// <summary>
        ///     Gets or sets the <see cref="IApplicationManager"/> mockup for the unit tests.
        /// </summary>
        private Mock<IApplicationManager> ApplicationManager { get; set; }

        /// <summary>
        ///     Gets or sets the <see cref="SecurityManagerConfiguration"/> for the Manager.
        /// </summary>
        private SecurityManagerConfiguration Configuration { get; set; }

        /// <summary>
        ///     Gets or sets the <see cref="IConfigurationManager"/> mockup for the unit tests.
        /// </summary>
        private Mock<IConfigurationManager> ConfigurationManager { get; set; }

        /// <summary>
        ///     Gets or sets the <see cref="ISecurityManager"/> instance under test.
        /// </summary>
        private ISecurityManager Manager { get; set; }

        /// <summary>
        ///     Gets or sets the <see cref="IUser"/> instance for the unit tests.
        /// </summary>
        private IUser User { get; set; }

        #endregion Private Properties

        #region Public Methods

        /// <summary>
        ///     Tests the constructor and all properties.
        /// </summary>
        [Fact]
        public void Constructor()
        {
            Assert.IsType<SecurityManager>(Manager);

            Assert.Equal(State.Initialized, Manager.State);
            Assert.NotEmpty(Manager.Roles);
            Assert.NotNull(Manager.Sessions);
            Assert.Null(Manager.Users);
        }

        /// <summary>
        ///     Tests the <see cref="SecurityManager.CreateUser(string, string, string, string, Role)"/> method.
        /// </summary>
        [Fact]
        public void CreateUser()
        {
            Manager.Start();

            string name = Guid.NewGuid().ToString();

            IResult<IUser> result = Manager.CreateUser(name, "test", "test@test.com", "password", Role.Reader);

            Assert.Equal(string.Empty, result.GetLastError());
            Assert.Equal(ResultCode.Success, result.ResultCode);
            Assert.Equal(name, result.ReturnValue.Name);
            Assert.Equal(Utility.ComputeSHA512Hash("password"), result.ReturnValue.PasswordHash);
            Assert.Equal(Role.Reader, result.ReturnValue.Role);

            Assert.True(((SecurityManager)Manager).Configuration.Users.Any(u => u.Name == name));
        }

        /// <summary>
        ///     Tests the <see cref="SecurityManager.CreateUser(string, string, string, string, Role)"/> method with a known bad
        ///     display name.
        /// </summary>
        [Fact]
        public void CreateUserBadDisplayName()
        {
            Manager.Start();

            IResult<IUser> result = Manager.CreateUser("name", null, "test@test.com", string.Empty, Role.Reader);

            Assert.Equal(ResultCode.Failure, result.ResultCode);
        }

        /// <summary>
        ///     Tests the <see cref="SecurityManager.CreateUser(string, string, string, string, Role)"/> method with a known bad email.
        /// </summary>
        [Fact]
        public void CreateUserBadEmail()
        {
            Manager.Start();

            IResult<IUser> result = Manager.CreateUser("name", "name", "email", string.Empty, Role.Reader);

            Assert.Equal(ResultCode.Failure, result.ResultCode);
        }

        /// <summary>
        ///     Tests the <see cref="SecurityManager.CreateUser(string, string, string, string, Role)"/> method with a known bad password.
        /// </summary>
        [Fact]
        public void CreateUserBadPassword()
        {
            Manager.Start();

            IResult<IUser> result = Manager.CreateUser("name", "test", "test@test.com", string.Empty, Role.Reader);

            Assert.Equal(ResultCode.Failure, result.ResultCode);
        }

        /// <summary>
        ///     Tests the <see cref="SecurityManager.CreateUser(string, string, string, string, Role)"/> method with a known bad user.
        /// </summary>
        [Fact]
        public void CreateUserBadUser()
        {
            Manager.Start();

            IResult<IUser> result = Manager.CreateUser(string.Empty, "test", "test@test.com", "password", Role.Reader);

            Assert.Equal(ResultCode.Failure, result.ResultCode);
        }

        /// <summary>
        ///     Tests the <see cref="SecurityManager.CreateUser(string, string, string, string, Role)"/> method with a missing email.
        /// </summary>
        [Fact]
        public void CreateUserNoEmail()
        {
            Manager.Start();

            IResult<IUser> result = Manager.CreateUser("name", "name", null, string.Empty, Role.Reader);

            Assert.Equal(ResultCode.Failure, result.ResultCode);
        }

        /// <summary>
        ///     Tests the <see cref="SecurityManager.CreateUser(string, string, string, string, Role)"/> method with an
        ///     <see cref="ISecurityManager"/> which nas not been started.
        /// </summary>
        [Fact]
        public void CreateUserNotStarted()
        {
            IResult<IUser> result = Manager.CreateUser("name", "test", "test@test.com", "password", Role.Reader);
            Assert.Equal(ResultCode.Failure, result.ResultCode);
        }

        /// <summary>
        ///     Tests the <see cref="SecurityManager.CreateUser(string, string, string, string, Role)"/> method with a known
        ///     existing user.
        /// </summary>
        [Fact]
        public void CreateUserUserExists()
        {
            Manager.Start();

            IResult<IUser> result = Manager.CreateUser("test", "test", "test@test.com", "password", Role.Reader); // name must match SetupMocks()

            Assert.Equal(ResultCode.Failure, result.ResultCode);
        }

        /// <summary>
        ///     Tests the <see cref="SecurityManager.DeleteUser(string)"/> method.
        /// </summary>
        [Fact]
        public void DeleteUser()
        {
            string name = Guid.NewGuid().ToString();
            string displayName = name;
            string email = name + "@test.com";
            string hash = Utility.ComputeSHA512Hash("test");

            Configuration.Users.Add(new User(name, displayName, email, hash, Role.Reader));

            Manager.Start();

            IResult result = Manager.DeleteUser(name);

            Assert.Equal(ResultCode.Success, result.ResultCode);
        }

        /// <summary>
        ///     Tests the <see cref="Core.Security.SecurityManager.DeleteUser(string)"/> method with a user which is not found.
        /// </summary>
        [Fact]
        public void DeleteUserNotFound()
        {
            Manager.Start();

            IResult result = Manager.DeleteUser(Guid.NewGuid().ToString());

            Assert.Equal(ResultCode.Failure, result.ResultCode);
        }

        /// <summary>
        ///     Tests the <see cref="Core.Security.SecurityManager.DeleteUser(string)"/> method with an
        ///     <see cref="ISecurityManager"/> which has not been started.
        /// </summary>
        [Fact]
        public void DeleteUserNotRunning()
        {
            string name = Guid.NewGuid().ToString();
            string hash = Utility.ComputeSHA512Hash("test");

            Configuration.Users.Add(new Core.Security.User(name, "user", "test@test.com", hash, Role.Reader));

            IResult result = Manager.DeleteUser(name);

            Assert.Equal(ResultCode.Failure, result.ResultCode);
        }

        /// <summary>
        ///     Tests the <see cref="SecurityManager.EndSession(ISession)"/> method.
        /// </summary>
        [Fact]
        public void EndSession()
        {
            Manager.Start();

            IResult<ISession> session = Manager.StartSession("test", "test");

            Assert.Equal(ResultCode.Success, session.ResultCode);

            IResult result = Manager.EndSession(session.ReturnValue);

            Assert.Equal(ResultCode.Success, result.ResultCode);
        }

        /// <summary>
        ///     Tests the <see cref="SecurityManager.EndSession(ISession)"/> method with an <see cref="ISecurityManager"/> which
        ///     has not been started.
        /// </summary>
        [Fact]
        public void EndSessionNotRunning()
        {
            IResult result = Manager.EndSession(new Session(User, new ClaimsIdentity()));

            Assert.Equal(ResultCode.Failure, result.ResultCode);
        }

        /// <summary>
        ///     Tests the <see cref="SecurityManager.EndSession(ISession)"/> method with a Session which can not be found.
        /// </summary>
        [Fact]
        public void EndSessionSessionNotFound()
        {
            Manager.Start();

            IResult result = Manager.EndSession(new Session(User, null));

            Assert.Equal(ResultCode.Failure, result.ResultCode);
        }

        /// <summary>
        ///     Tests the <see cref="SecurityManager.EndSession(ISession)"/> method with a null Session.
        /// </summary>
        [Fact]
        public void EndSessionSessionNull()
        {
            Manager.Start();

            IResult result = Manager.EndSession(null);

            Assert.Equal(ResultCode.Failure, result.ResultCode);
        }

        /// <summary>
        ///     Tests the <see cref="SecurityManager.ExtendSession(ISession)"/> method.
        /// </summary>
        [Fact]
        public void ExtendSession()
        {
            Manager.Start();

            IResult<ISession> session = Manager.StartSession("test", "test");
            DateTimeOffset? offset = session.ReturnValue.Expires;

            Assert.Equal(ResultCode.Success, session.ResultCode);

            Configuration.SessionLength = Configuration.SessionLength * 2;

            IResult<ISession> result = Manager.ExtendSession(session.ReturnValue);

            Assert.Equal(ResultCode.Success, result.ResultCode);
            Assert.True(result.ReturnValue.Expires > offset);
        }

        /// <summary>
        ///     Tests the <see cref="SecurityManager.ExtendSession(ISession)"/> method with a Session which has expired.
        /// </summary>
        [Fact]
        public void ExtendSessionExpired()
        {
            Manager.Start();

            IResult<ISession> session = Manager.StartSession("test", "test");

            Assert.Equal(ResultCode.Success, session.ResultCode);

            session.ReturnValue.Expires = session.ReturnValue.Created.AddMinutes(-1);

            IResult<ISession> result = Manager.ExtendSession(session.ReturnValue);

            Assert.Equal(ResultCode.Failure, result.ResultCode);
        }

        /// <summary>
        ///     Tests the <see cref="SecurityManager.ExtendSession(ISession)"/> method with a Session which can not be found.
        /// </summary>
        [Fact]
        public void ExtendSessionNotFound()
        {
            Manager.Start();

            IResult<ISession> result = Manager.ExtendSession(new Session(User, null));

            Assert.Equal(ResultCode.Failure, result.ResultCode);
        }

        /// <summary>
        ///     Tests the <see cref="SecurityManager.ExtendSession(ISession)"/> method with an <see cref="ISecurityManager"/> which
        ///     has not been started.
        /// </summary>
        [Fact]
        public void ExtendSessionNotRunning()
        {
            IResult result = Manager.ExtendSession(new Session(User, null));

            Assert.Equal(ResultCode.Failure, result.ResultCode);
        }

        /// <summary>
        ///     Tests the <see cref="SecurityManager.ExtendSession(ISession)"/> method with a null Session.
        /// </summary>
        [Fact]
        public void ExtendSessionSessionNull()
        {
            Manager.Start();

            IResult result = Manager.ExtendSession(null);

            Assert.Equal(ResultCode.Failure, result.ResultCode);
        }

        /// <summary>
        ///     Tests the <see cref="SecurityManager.ExtendSession(ISession)"/> method with a configuration in which
        ///     SlidingSessions is false.
        /// </summary>
        [Fact]
        public void ExtendSessionSlidingSessionsNotEnabled()
        {
            Manager.Start();

            IResult<ISession> session = Manager.StartSession("test", "test");
            DateTimeOffset? offset = session.ReturnValue.Expires;

            Assert.Equal(ResultCode.Success, session.ResultCode);

            Configuration.SlidingSessions = false;

            IResult<ISession> result = Manager.ExtendSession(session.ReturnValue);

            Assert.Equal(ResultCode.Warning, result.ResultCode);
        }

        /// <summary>
        ///     Tests the <see cref="SecurityManager.FindSession(string)"/> method.
        /// </summary>
        [Fact]
        public void FindSession()
        {
            Manager.Start();

            IResult<ISession> session = Manager.StartSession("test", "test");

            Assert.Equal(ResultCode.Success, session.ResultCode);

            ISession foundSession = Manager.FindSession(session.ReturnValue.Token);

            Assert.NotEqual(default(ISession), foundSession);
            Assert.Equal("test", foundSession.Identity.Name);
        }

        /// <summary>
        ///     Tests the <see cref="SecurityManager.FindSession(string)"/> method with a Session which can not be found.
        /// </summary>
        [Fact]
        public void FindSessionNotFound()
        {
            ISession foundSession = Manager.FindSession(Guid.NewGuid().ToString());

            Assert.Equal(default(ISession), foundSession);
        }

        /// <summary>
        ///     Tests the <see cref="SecurityManager.FindUser(string)"/> method.
        /// </summary>
        [Fact]
        public void FindUser()
        {
            Manager.Start();

            string name = Guid.NewGuid().ToString();
            Configuration.Users.Add(new User(name, "user", "test@test.com", "hash", Role.Reader));

            IUser user = Manager.FindUser(name);

            Assert.NotEqual(default(User), user);
            Assert.Equal(user.Name, name);
            Assert.Equal(user.PasswordHash, "hash");
            Assert.Equal(user.Role, Role.Reader);
        }

        /// <summary>
        ///     Tests the <see cref="SecurityManager.FindUser(string)"/> method with a User which can not be found.
        /// </summary>
        [Fact]
        public void FindUserNotFound()
        {
            string name = Guid.NewGuid().ToString();

            IUser user = Manager.FindUser(name);

            Assert.Equal(default(User), user);
        }

        /// <summary>
        ///     Tests the <see cref="SecurityManager.FindUserSession(string)"/> method.
        /// </summary>
        [Fact]
        public void FindUserSession()
        {
            Manager.Start();

            IResult<ISession> session = Manager.StartSession("test", "test");

            Assert.Equal(ResultCode.Success, session.ResultCode);

            ISession foundSession = Manager.FindUserSession("test");

            Assert.NotEqual(default(ISession), foundSession);
            Assert.Equal("test", foundSession.Identity.Name);
        }

        /// <summary>
        ///     Tests the <see cref="SecurityManager.FindUserSession(string)"/> method with a Session which can not be found.
        /// </summary>
        [Fact]
        public void FindUserSessionNotFound()
        {
            ISession foundSession = Manager.FindUserSession(Guid.NewGuid().ToString());

            Assert.Equal(default(ISession), foundSession);
        }

        /// <summary>
        ///     Tests the <see cref="SecurityManager.GetConfigurationDefinition"/> method.
        /// </summary>
        [Fact]
        public void GetConfigurationDefinition()
        {
            IConfigurationDefinition configdef = SecurityManager.GetConfigurationDefinition();

            Assert.False(string.IsNullOrEmpty(configdef.Form));
            Assert.False(string.IsNullOrEmpty(configdef.Schema));
            Assert.NotNull(configdef.Model);

            SecurityManagerConfiguration config = (SecurityManagerConfiguration)configdef.DefaultConfiguration;

            Assert.NotNull(config.SessionLength);
            Assert.NotNull(config.SessionPurgeInterval);
            Assert.NotEmpty(config.Users);
        }

        /// <summary>
        ///     Tests the <see cref="SecurityManager.Instantiate(IApplicationManager, IConfigurationManager)"/> method.
        /// </summary>
        [Fact]
        public void Instantiate()
        {
            SecurityManager.Terminate();

            ISecurityManager manager = SecurityManager.Instantiate(ApplicationManager.Object, ConfigurationManager.Object);

            Assert.IsType<SecurityManager>(manager);
        }

        /// <summary>
        ///     Tests the <see cref="SecurityManager.Instantiate(IApplicationManager, IConfigurationManager)"/> method twice in succession.
        /// </summary>
        [Fact]
        public void InstantiateTwice()
        {
            SecurityManager.Terminate();

            ISecurityManager manager = SecurityManager.Instantiate(ApplicationManager.Object, ConfigurationManager.Object);

            Assert.IsType<SecurityManager>(manager);

            ISecurityManager manager2 = SecurityManager.Instantiate(ApplicationManager.Object, ConfigurationManager.Object);

            Assert.IsType<SecurityManager>(manager2);
            Assert.Same(manager, manager2);
        }

        /// <summary>
        ///     Tests the PurgeExpiredSessions method via reflection.
        /// </summary>
        [Fact]
        public void PurgeExpiredSessions()
        {
            Manager.Start();

            string name1 = Guid.NewGuid().ToString();
            string name2 = Guid.NewGuid().ToString();

            Manager.CreateUser(name1, "test", "test@test.com", "test", Role.Reader);
            ISession session1 = Manager.StartSession(name1, "test").ReturnValue;
            session1.Expires = session1.Created.AddMinutes(-1);

            Assert.True(session1.IsExpired);

            Manager.CreateUser(name2, "test", "test@test.com", "test", Role.Reader);
            ISession session2 = Manager.StartSession(name2, "test").ReturnValue;

            Assert.False(session2.IsExpired);

            Assert.Equal(2, Manager.Sessions.Count());

            // invoke the purge via reflection since the timer would be tricky to set up.
            MethodInfo purge = typeof(SecurityManager).GetMethod("PurgeExpiredSessions", BindingFlags.NonPublic | BindingFlags.Instance);

            Exception ex = Record.Exception(() => purge.Invoke(Manager, new object[] { }));

            Assert.Null(ex);

            Assert.Equal(1, Manager.Sessions.Count());
        }

        /// <summary>
        ///     Tests the <see cref="SecurityManager.Setup"/> method using reflection.
        /// </summary>
        [Fact]
        public void Setup()
        {
            MethodInfo setup = typeof(SecurityManager).GetMethod("Setup", BindingFlags.NonPublic | BindingFlags.Instance);
            setup.Invoke(Manager, new object[] { });
        }

        /// <summary>
        ///     Tests the <see cref="SecurityManager.Startup()"/> method via <see cref="Core.Common.Manager.Start()"/>.
        /// </summary>
        [Fact]
        public void Start()
        {
            IResult result = Manager.Start();

            Assert.Equal(string.Empty, result.GetLastError());
            Assert.NotEqual(ResultCode.Failure, result.ResultCode);
            Assert.Equal(State.Running, Manager.State);
        }

        /// <summary>
        ///     Tests the <see cref="SecurityManager.Startup()"/> method via <see cref="Core.Common.Manager.Start()"/> with a
        ///     configuration failure.
        /// </summary>
        [Fact]
        public void StartConfigurationFailure()
        {
            ApplicationConfiguration.Setup(
                c => c.GetInstance<SecurityManagerConfiguration>(It.IsAny<Type>()))
                    .Returns(new Result<SecurityManagerConfiguration>(ResultCode.Failure));

            ApplicationConfiguration.Setup(
                c => c.AddInstance<SecurityManagerConfiguration>(It.IsAny<Type>(), It.IsAny<object>()))
                    .Returns(new Result<SecurityManagerConfiguration>(ResultCode.Failure));

            Exception ex = Record.Exception(() => Manager.Start());

            Assert.NotNull(ex);
            Assert.IsType<ManagerStartException>(ex);
        }

        /// <summary>
        ///     Tests the <see cref="SecurityManager.Startup()"/> method via <see cref="Core.Common.Manager.Start()"/> with a
        ///     failing Configuration.
        /// </summary>
        [Fact]
        public void StartNotConfigured()
        {
            ApplicationConfiguration.Setup(
                c => c.GetInstance<SecurityManagerConfiguration>(It.IsAny<Type>()))
                    .Returns(new Result<SecurityManagerConfiguration>(ResultCode.Failure));

            ApplicationConfiguration.Setup(
                c => c.AddInstance<SecurityManagerConfiguration>(It.IsAny<Type>(), It.IsAny<object>()))
                    .Returns(new Result<SecurityManagerConfiguration>().SetReturnValue(Configuration));

            IResult result = Manager.Start();

            Assert.Equal(string.Empty, result.GetLastError());
            Assert.NotEqual(ResultCode.Failure, result.ResultCode);
            Assert.Equal(State.Running, Manager.State);
        }

        /// <summary>
        ///     Tests the <see cref="SecurityManager.StartSession(string, string)"/> method.
        /// </summary>
        [Fact]
        public void StartSession()
        {
            Manager.Start();

            IResult<ISession> result = Manager.StartSession("test", "test");

            Assert.Equal(ResultCode.Success, result.ResultCode);
            Assert.Equal("test", result.ReturnValue.Identity.Name);
        }

        /// <summary>
        ///     Tests the <see cref="SecurityManager.StartSession(string, string)"/> method with a known bad password.
        /// </summary>
        [Fact]
        public void StartSessionBadPassword()
        {
            Manager.Start();

            IResult<ISession> result = Manager.StartSession("test", "bad");

            Assert.Equal(ResultCode.Failure, result.ResultCode);
        }

        /// <summary>
        ///     Tests the <see cref="SecurityManager.StartSession(string, string)"/> method with a User which has an existing Session.
        /// </summary>
        [Fact]
        public void StartSessionExistingSession()
        {
            Manager.Start();

            IResult<ISession> session1 = Manager.StartSession("test", "test");

            Assert.Equal(ResultCode.Success, session1.ResultCode);
            Assert.Equal("test", session1.ReturnValue.Identity.Name);

            IResult<ISession> session2 = Manager.StartSession("test", "test");

            Assert.Same(session1.ReturnValue, session2.ReturnValue);
        }

        /// <summary>
        ///     Tests the <see cref="SecurityManager.StartSession(string, string)"/> method with an <see cref="ISecurityManager"/>
        ///     which has not been started.
        /// </summary>
        [Fact]
        public void StartSessionNotStarted()
        {
            IResult<ISession> result = Manager.StartSession("test", "test");

            Assert.Equal(ResultCode.Failure, result.ResultCode);
        }

        /// <summary>
        ///     Tests the <see cref="SecurityManager.StartSession(string, string)"/> method with a User which can not be found.
        /// </summary>
        [Fact]
        public void StartSessionUserNotFound()
        {
            Manager.Start();

            IResult<ISession> result = Manager.StartSession(Guid.NewGuid().ToString(), "test");

            Assert.Equal(ResultCode.Failure, result.ResultCode);
        }

        /// <summary>
        ///     Tests the Shutdown method via Manager.Stop.
        /// </summary>
        [Fact]
        public void Stop()
        {
            IResult result = Manager.Start();

            Assert.Equal(string.Empty, result.GetLastError());
            Assert.NotEqual(ResultCode.Failure, result.ResultCode);
            Assert.Equal(State.Running, Manager.State);

            result = Manager.Stop();

            Assert.Equal(string.Empty, result.GetLastError());
            Assert.NotEqual(ResultCode.Failure, result.ResultCode);
            Assert.Equal(State.Stopped, Manager.State);
        }

        /// <summary>
        ///     Tests the <see cref="SecurityManager.UpdateUser(string, string, string, string, Role?)"/> method.
        /// </summary>
        [Fact]
        public void UpdateUser()
        {
            Manager.Start();

            string name = Guid.NewGuid().ToString();
            string hash = Utility.ComputeSHA512Hash("test2");

            Manager.CreateUser(name, "test", "test@test.com", "test", Role.Reader);

            IResult<IUser> user = Manager.UpdateUser(name, "test", "test@test.com", "test2", Role.ReadWriter);

            Assert.Equal(ResultCode.Success, user.ResultCode);
            Assert.Equal(name, user.ReturnValue.Name);
            Assert.Equal(hash, user.ReturnValue.PasswordHash);
            Assert.Equal(Role.ReadWriter, user.ReturnValue.Role);
        }

        /// <summary>
        ///     Tests the <see cref="SecurityManager.UpdateUser(string, string, string, string, Role?)"/> method with a known bad
        ///     display name.
        /// </summary>
        [Fact]
        public void UpdateUserBadDisplayName()
        {
            Manager.Start();

            IResult<IUser> user = Manager.UpdateUser("name", string.Empty, "test@test.com", "password", Role.ReadWriter);

            Assert.Equal(ResultCode.Failure, user.ResultCode);
        }

        /// <summary>
        ///     Tests the <see cref="SecurityManager.UpdateUser(string, string, string, string, Role?)"/> method with a known bad email.
        /// </summary>
        [Fact]
        public void UpdateUserBadEmail()
        {
            Manager.Start();

            IResult<IUser> user = Manager.UpdateUser("name", "name", "test", "password", Role.ReadWriter);

            Assert.Equal(ResultCode.Failure, user.ResultCode);
        }

        /// <summary>
        ///     Tests the <see cref="SecurityManager.UpdateUser(string, string, string, string, Role?)"/> method with a known bad password.
        /// </summary>
        [Fact]
        public void UpdateUserBadPassword()
        {
            Manager.Start();

            IResult<IUser> user = Manager.UpdateUser("name", "test", "test@test.com", string.Empty, Role.ReadWriter);

            Assert.Equal(ResultCode.Failure, user.ResultCode);
        }

        /// <summary>
        ///     Tests the <see cref="SecurityManager.UpdateUser(string, string, string, string, Role?)"/> method with an updated
        ///     display name.
        /// </summary>
        [Fact]
        public void UpdateUserDisplayName()
        {
            Manager.Start();

            string name = Guid.NewGuid().ToString();

            Manager.CreateUser(name, "test", "test@test.com", "test", Role.Reader);

            IResult<IUser> user = Manager.UpdateUser(name, "display", null, null, null);

            Assert.Equal(ResultCode.Success, user.ResultCode);
            Assert.Equal(name, user.ReturnValue.Name);
            Assert.Equal("display", user.ReturnValue.DisplayName);
            Assert.Equal(Role.Reader, user.ReturnValue.Role);
        }

        /// <summary>
        ///     Tests the <see cref="SecurityManager.UpdateUser(string, string, string, string, Role?)"/> method with an updated email.
        /// </summary>
        [Fact]
        public void UpdateUserEmail()
        {
            Manager.Start();

            string name = Guid.NewGuid().ToString();

            Manager.CreateUser(name, "test", "test@test.com", "test", Role.Reader);

            IResult<IUser> user = Manager.UpdateUser(name, null, "email@email.com", null, null);

            Assert.Equal(ResultCode.Success, user.ResultCode);
            Assert.Equal(name, user.ReturnValue.Name);
            Assert.Equal("email@email.com", user.ReturnValue.Email);
            Assert.Equal(Role.Reader, user.ReturnValue.Role);
        }

        /// <summary>
        ///     Tests the <see cref="SecurityManager.UpdateUser(string, string, string, string, Role?)"/> method with neither an
        ///     updated password nor Role.
        /// </summary>
        [Fact]
        public void UpdateUserNothingToUpdate()
        {
            Manager.Start();

            IResult<IUser> user = Manager.UpdateUser("name", null, null);

            Assert.Equal(ResultCode.Failure, user.ResultCode);
        }

        /// <summary>
        ///     Tests the <see cref="SecurityManager.UpdateUser(string, string, string, string, Role?)"/> method with an
        ///     <see cref="ISecurityManager"/> which has not been started.
        /// </summary>
        [Fact]
        public void UpdateUserNotRunning()
        {
            IResult<IUser> user = Manager.UpdateUser("name", "test", "test@test.com", "test", Role.ReadWriter);

            Assert.Equal(ResultCode.Failure, user.ResultCode);
        }

        /// <summary>
        ///     Tests the <see cref="SecurityManager.UpdateUser(string, string, string, string, Role?)"/> method with an updated password.
        /// </summary>
        [Fact]
        public void UpdateUserPassword()
        {
            Manager.Start();

            string name = Guid.NewGuid().ToString();
            string hash = Utility.ComputeSHA512Hash("test2");

            Manager.CreateUser(name, "test", "test@test.com", "test", Role.Reader);

            IResult<IUser> user = Manager.UpdateUser(name, null, null, "test2", null);

            Assert.Equal(ResultCode.Success, user.ResultCode);
            Assert.Equal(name, user.ReturnValue.Name);
            Assert.Equal(hash, user.ReturnValue.PasswordHash);
            Assert.Equal(Role.Reader, user.ReturnValue.Role);
        }

        /// <summary>
        ///     Tests the <see cref="SecurityManager.UpdateUser(string, string, string, string, Role?)"/> method with an updated Role.
        /// </summary>
        [Fact]
        public void UpdateUserRole()
        {
            Manager.Start();

            string name = Guid.NewGuid().ToString();

            Manager.CreateUser(name, "test", "test@test.com", "test", Role.Reader);

            IResult<IUser> user = Manager.UpdateUser(name, null, null, null, Role.ReadWriter);

            Assert.Equal(ResultCode.Success, user.ResultCode);
            Assert.Equal(name, user.ReturnValue.Name);
            Assert.Equal(Role.ReadWriter, user.ReturnValue.Role);
        }

        /// <summary>
        ///     Tests the <see cref="SecurityManager.UpdateUser(string, string, string, string, Role?)"/> method with a User which
        ///     can not be found.
        /// </summary>
        [Fact]
        public void UpdateUserUserNotFound()
        {
            Manager.Start();

            string name = Guid.NewGuid().ToString();

            IResult<IUser> user = Manager.UpdateUser(name, "test", "test@test.com", "test", Role.ReadWriter);

            Assert.Equal(ResultCode.Failure, user.ResultCode);
        }

        /// <summary>
        ///     Tests the <see cref="SecurityManager.Users"/> property.
        /// </summary>
        [Fact]
        public void Users()
        {
            Assert.Null(Manager.Users);

            Manager.Start();

            Assert.NotNull(Manager.Users);
        }

        /// <summary>
        ///     Tests the <see cref="SecurityManager.Users"/> property with an empty Users collection.
        /// </summary>
        [Fact]
        public void UsersEmpty()
        {
            Configuration.Users = new List<User>();

            Manager.Start();

            Assert.Empty(Manager.Users);
        }

        #endregion Public Methods

        #region Private Methods

        /// <summary>
        ///     Configures the mockups for the unit tests.
        /// </summary>
        private void SetupMocks()
        {
            ApplicationManager = new Mock<IApplicationManager>();
            ApplicationManager.Setup(a => a.State).Returns(State.Running);
            ApplicationManager.Setup(a => a.IsInState(State.Starting, State.Running)).Returns(true);
            ApplicationManager.Setup(a => a.Settings).Returns(new Core.ApplicationSettings());

            Configuration = new SecurityManagerConfiguration();
            Configuration.SessionLength = 900;
            Configuration.SessionPurgeInterval = 90000;
            Configuration.SlidingSessions = true;
            Configuration.Users = new[] { new User("test", "user", "test@test.com", Utility.ComputeSHA512Hash("test"), Role.Reader) }.ToList();

            ApplicationConfiguration = new Mock<IConfiguration>();

            ApplicationConfiguration.Setup(
                c => c.GetInstance<SecurityManagerConfiguration>(It.IsAny<Type>()))
                    .Returns(new Result<SecurityManagerConfiguration>().SetReturnValue(Configuration));

            ApplicationConfiguration.Setup(
                c => c.UpdateInstance(It.IsAny<Type>(), It.IsAny<object>()))
                    .Returns(new Result());

            ConfigurationManager = new Mock<IConfigurationManager>();
            ConfigurationManager.Setup(c => c.Configuration).Returns(ApplicationConfiguration.Object);
            ConfigurationManager.Setup(c => c.State).Returns(State.Running);
            ConfigurationManager.Setup(c => c.IsInState(State.Starting, State.Running)).Returns(true);

            User = new User("name", "displayName", "name@test.com", "hash", Role.Reader);
        }

        #endregion Private Methods
    }
}