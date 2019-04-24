/*
* DO NOT EDIT MANUALLY.
* This file is automatically generrated by gitai_msgs/generate_csharp.py
*/
using Newtonsoft.Json;
namespace RosSharp.RosBridgeClient.Messages.Gitai
{
public class EyeViewPoint : Message
{
[JsonIgnore]
public const string RosMessageName = "gitai_msgs/EyeViewPoint";
public Standard.Header header;
public Geometry.Quaternion orientation;
}
}
