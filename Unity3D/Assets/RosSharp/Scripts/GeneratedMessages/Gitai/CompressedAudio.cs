/*
* DO NOT EDIT MANUALLY.
* This file is automatically generrated by gitai_msgs/generate_csharp.py
*/
using Newtonsoft.Json;
namespace RosSharp.RosBridgeClient.Messages.Gitai
{
public class CompressedAudio : Message
{
[JsonIgnore]
public const string RosMessageName = "gitai_msgs/CompressedAudio";
public Standard.Header header;
public string format;
public uint data;
}
}
