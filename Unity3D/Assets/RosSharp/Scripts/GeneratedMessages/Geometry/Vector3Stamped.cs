/*
* DO NOT EDIT MANUALLY.
* This file is automatically generrated by gitai_msgs/generate_csharp.py
*/
using Newtonsoft.Json;
namespace RosSharp.RosBridgeClient.Messages.Geometry
{
public class Vector3Stamped : Message
{
[JsonIgnore]
public const string RosMessageName = "geometry_msgs/Vector3Stamped";
public Standard.Header header;
public Geometry.Vector3 vector;
}
}
