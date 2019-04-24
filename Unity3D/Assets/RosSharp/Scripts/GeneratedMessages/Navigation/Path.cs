/*
* DO NOT EDIT MANUALLY.
* This file is automatically generrated by gitai_msgs/generate_csharp.py
*/
using Newtonsoft.Json;
namespace RosSharp.RosBridgeClient.Messages.Navigation
{
public class Path : Message
{
[JsonIgnore]
public const string RosMessageName = "nav_msgs/Path";
public Standard.Header header;
public Geometry.PoseStamped poses;
}
}
