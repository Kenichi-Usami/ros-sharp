/*
* DO NOT EDIT MANUALLY.
* This file is automatically generrated by gitai_msgs/generate_csharp.py
*/
using Newtonsoft.Json;
namespace RosSharp.RosBridgeClient.Messages.Gitai
{
public class Audio : Message
{
[JsonIgnore]
public const string RosMessageName = "gitai_msgs/Audio";
public Standard.Header header;
public string format;
public uint rate;
public uint channels;
public string layout;
public uint data;
}
}
