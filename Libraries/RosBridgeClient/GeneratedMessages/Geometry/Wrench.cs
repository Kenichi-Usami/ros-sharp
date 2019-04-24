/*
* DO NOT EDIT MANUALLY.
* This file is automatically generrated by gitai_msgs/generate_csharp.py
*/
using Newtonsoft.Json;
namespace RosSharp.RosBridgeClient.Messages.Geometry
{
public class Wrench : Message
{
[JsonIgnore]
public const string RosMessageName = "geometry_msgs/Wrench";
public Geometry.Vector3 force;
public Geometry.Vector3 torque;
}
}
