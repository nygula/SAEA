﻿/****************************************************************************
*项目名称：SAEA.MQTT.Core
*CLR 版本：4.0.30319.42000
*机器名称：WENLI-PC
*命名空间：SAEA.MQTT.Model
*类 名 称：MqttMessage
*版 本 号： v4.2.1.6
*创建人： yswenli
*电子邮箱：wenguoli_520@qq.com
*创建时间：2019/1/15 10:28:57
*描述：
*=====================================================================
*修改时间：2019/1/15 10:28:57
*修 改 人： yswenli
*版 本 号： v4.2.1.6
*描    述：
*****************************************************************************/
using SAEA.MQTT.Core.Protocol;

namespace SAEA.MQTT.Model
{
    public class MqttMessage
    {
        public string Topic { get; set; }

        public byte[] Payload { get; set; }

        public MqttQualityOfServiceLevel QualityOfServiceLevel { get; set; }

        public bool Retain { get; set; }
    }
}
