/*
* DO NOT EDIT MANUALLY.
* This file is automatically generrated by gitai_msgs/generate_csharp.py
*/
using Newtonsoft.Json;
namespace RosSharp.RosBridgeClient.Messages.Sensor
{
public class NavSatFix : Message
{
[JsonIgnore]
public const string RosMessageName = "sensor_msgs/NavSatFix";
public Standard.Header header;
public Sensor.NavSatStatus status;
public float latitude;
public float longitude;
public float altitude;
public float position_covariance;
public uint position_covariance_type;
}
}
