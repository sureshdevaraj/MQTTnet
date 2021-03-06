﻿using MQTTnet.Core.Client;
using MQTTnet.Implementations;

namespace MQTTnet
{
    public class MqttClientFactory : IMqttClientFactory
    {
        public IMqttClient CreateMqttClient()
        {
            return new MqttClient(new MqttCommunicationAdapterFactory());
        }
    }
}