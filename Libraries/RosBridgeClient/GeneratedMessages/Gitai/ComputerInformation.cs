/*
* DO NOT EDIT MANUALLY.
* This file is automatically generrated by gitai_msgs/generate_csharp.py
*/
using Newtonsoft.Json;
namespace RosSharp.RosBridgeClient.Messages.Gitai
{
public class ComputerInformation : Message
{
[JsonIgnore]
public const string RosMessageName = "gitai_msgs/ComputerInformation";
public Standard.Header header;
public string hostname;
public string user;
}
}
