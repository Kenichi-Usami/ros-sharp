/*
* DO NOT EDIT MANUALLY.
* This file is automatically generrated by gitai_msgs/generate_csharp.py
*/
using Newtonsoft.Json;
namespace RosSharp.RosBridgeClient.Messages.Geometry
{
public class Inertia : Message
{
[JsonIgnore]
public const string RosMessageName = "geometry_msgs/Inertia";
public float m;
public Geometry.Vector3 com;
public float ixx;
public float ixy;
public float ixz;
public float iyy;
public float iyz;
public float izz;
}
}
