/*
* DO NOT EDIT MANUALLY.
* This file is automatically generrated by gitai_msgs/generate_csharp.py
*/
using Newtonsoft.Json;
namespace RosSharp.RosBridgeClient.Messages.Sensor
{
public class MagneticField : Message
{
[JsonIgnore]
public const string RosMessageName = "sensor_msgs/MagneticField";
public Standard.Header header;
public Geometry.Vector3 magnetic_field;
public float magnetic_field_covariance;
}
}
