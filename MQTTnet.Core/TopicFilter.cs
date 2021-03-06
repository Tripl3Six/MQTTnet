﻿using MQTTnet.Core.Protocol;

namespace MQTTnet.Core
{
    public sealed class TopicFilter
    {
        public TopicFilter(string topic, MqttQualityOfServiceLevel qualityOfServiceLevel = MqttQualityOfServiceLevel.AtMostOnce)
        {
            Topic = topic;
            QualityOfServiceLevel = qualityOfServiceLevel;
        }

        public string Topic { get; }

        public MqttQualityOfServiceLevel QualityOfServiceLevel { get; }

        public override int GetHashCode()
        {
            return QualityOfServiceLevel.GetHashCode() ^ (Topic ?? string.Empty).GetHashCode();
        }

        public override string ToString()
        {
            return Topic + "@" + QualityOfServiceLevel;
        }
    }
}