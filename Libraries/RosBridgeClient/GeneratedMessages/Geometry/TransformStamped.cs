/*
* DO NOT EDIT MANUALLY.
* This file is automatically generrated by gitai_msgs/generate_csharp.py
*/
using Newtonsoft.Json;
namespace RosSharp.RosBridgeClient.Messages.Geometry
{
public class TransformStamped : Message
{
[JsonIgnore]
public const string RosMessageName = "geometry_msgs/TransformStamped";
public Standard.Header header;
public string child_frame_id;
public Geometry.Transform transform;
}
}
