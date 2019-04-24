/*
* DO NOT EDIT MANUALLY.
* This file is automatically generrated by gitai_msgs/generate_csharp.py
*/
using Newtonsoft.Json;
namespace RosSharp.RosBridgeClient.Messages.Gitai
{
public class TransferAddress : Message
{
[JsonIgnore]
public const string RosMessageName = "gitai_msgs/TransferAddress";
public Standard.Header header;
public string send_ip_address;
public int send_port;
public int send_source_port;
public int receive_port;
}
}
