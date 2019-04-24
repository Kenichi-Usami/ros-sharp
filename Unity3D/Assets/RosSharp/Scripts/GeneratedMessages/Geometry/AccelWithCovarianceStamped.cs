/*
* DO NOT EDIT MANUALLY.
* This file is automatically generrated by gitai_msgs/generate_csharp.py
*/
using Newtonsoft.Json;
namespace RosSharp.RosBridgeClient.Messages.Geometry
{
public class AccelWithCovarianceStamped : Message
{
[JsonIgnore]
public const string RosMessageName = "geometry_msgs/AccelWithCovarianceStamped";
public Standard.Header header;
public Geometry.AccelWithCovariance accel;
}
}
