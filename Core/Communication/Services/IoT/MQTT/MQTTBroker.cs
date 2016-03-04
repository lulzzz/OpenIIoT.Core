﻿using NLog;
using Symbiote.Core.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Symbiote.Core.Communication.Services.IoT.MQTT
{
    public class MQTTBroker : IService, IConfigurable<MQTTBrokerConfiguration>
    {
        private ProgramManager manager;
        private static Logger logger = LogManager.GetCurrentClassLogger();
        private static MQTTBroker instance;
        private static bool running;

        public ConfigurationDefinition ConfigurationDefinition { get { return GetConfigurationDefinition(); } }
        public MQTTBrokerConfiguration Configuration { get; private set; }
        public bool IsRunning { get { return running; } }

        private MQTTBroker(ProgramManager manager)
        {
            this.manager = manager;
            running = false;
        }

        public static MQTTBroker Instance(ProgramManager manager)
        {
            if (instance == null)
                instance = new MQTTBroker(manager);

            return instance;
        }

        public OperationResult Configure()
        {
            return Configure(manager.ConfigurationManager.GetConfiguration<MQTTBrokerConfiguration>(this.GetType()).Result);
        }

        public OperationResult Configure(MQTTBrokerConfiguration configuration)
        {
            Configuration = configuration;
            return new OperationResult();
        }

        public static ConfigurationDefinition GetConfigurationDefinition()
        {
            ConfigurationDefinition retVal = new ConfigurationDefinition();
            retVal.SetForm("[\"name\",\"email\",{\"key\":\"comment\",\"type\":\"textarea\",\"placeholder\":\"Make a comment\"},{\"type\":\"submit\",\"style\":\"btn-info\",\"title\":\"OK\"}]");
            retVal.SetSchema("{\"type\":\"object\",\"title\":\"Comment\",\"properties\":{\"name\":{\"title\":\"Name\",\"type\":\"string\"},\"email\":{\"title\":\"Email\",\"type\":\"string\",\"pattern\":\"^\\\\S+@\\\\S+$\",\"description\":\"Email will be used for evil.\"},\"comment\":{\"title\":\"Comment\",\"type\":\"string\",\"maxLength\":20,\"validationMessage\":\"Don\'t be greedy!\"}},\"required\":[\"name\",\"email\",\"comment\"]}");
            retVal.SetModel(typeof(MQTTBrokerConfiguration));
            return retVal;
        }

        public static MQTTBrokerConfiguration GetDefaultConfiguration()
        {
            MQTTBrokerConfiguration retVal = new MQTTBrokerConfiguration();
            retVal.Name = "";
            return retVal;
        }

        public OperationResult Start()
        {
            logger.Info("Starting MQTT Broker...");
            running = false;
            logger.Info("The MQTT Broker was started successfully.");
            return new OperationResult();
        }

        public OperationResult Stop()
        {
            logger.Info("Stopping MQTT Broker...");

            running = false;
            return new OperationResult();
        }
    }

    public class MQTTBrokerConfiguration
    {
        public string Name { get; set; }
    }
}