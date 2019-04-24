/*
* DO NOT EDIT MANUALLY.
* This file is automatically generrated by gitai_msgs/generate_csharp.py
*/
using Newtonsoft.Json;
namespace RosSharp.RosBridgeClient.Messages.Gitai
{
public class TransferConfigState : Message
{
[JsonIgnore]
public const string RosMessageName = "gitai_msgs/TransferConfigState";
public Standard.Header header;
public string ip_01;
public int run_mode;
public int port_send_01;
public int port_receive_01;
public int port_source_01;
}
}
