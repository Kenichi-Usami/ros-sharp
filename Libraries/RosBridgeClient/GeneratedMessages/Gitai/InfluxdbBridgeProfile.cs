/*
* DO NOT EDIT MANUALLY.
* This file is automatically generrated by gitai_msgs/generate_csharp.py
*/
using Newtonsoft.Json;
namespace RosSharp.RosBridgeClient.Messages.Gitai
{
public class InfluxdbBridgeProfile : Message
{
[JsonIgnore]
public const string RosMessageName = "gitai_msgs/InfluxdbBridgeProfile";
public Standard.Header header;
public int rx_messages;
public int tx_messages;
}
}
