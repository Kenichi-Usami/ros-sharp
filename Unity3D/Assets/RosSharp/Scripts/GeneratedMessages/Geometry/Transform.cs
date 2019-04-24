/*
* DO NOT EDIT MANUALLY.
* This file is automatically generrated by gitai_msgs/generate_csharp.py
*/
using Newtonsoft.Json;
namespace RosSharp.RosBridgeClient.Messages.Geometry
{
public class Transform : Message
{
[JsonIgnore]
public const string RosMessageName = "geometry_msgs/Transform";
public Geometry.Vector3 translation;
public Geometry.Quaternion rotation;
}
}
