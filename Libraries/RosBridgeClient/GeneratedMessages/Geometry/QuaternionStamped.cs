/*
* DO NOT EDIT MANUALLY.
* This file is automatically generrated by gitai_msgs/generate_csharp.py
*/
using Newtonsoft.Json;
namespace RosSharp.RosBridgeClient.Messages.Geometry
{
public class QuaternionStamped : Message
{
[JsonIgnore]
public const string RosMessageName = "geometry_msgs/QuaternionStamped";
public Standard.Header header;
public Geometry.Quaternion quaternion;
}
}
