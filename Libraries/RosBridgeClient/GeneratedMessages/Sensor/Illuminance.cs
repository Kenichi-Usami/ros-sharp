/*
* DO NOT EDIT MANUALLY.
* This file is automatically generrated by gitai_msgs/generate_csharp.py
*/
using Newtonsoft.Json;
namespace RosSharp.RosBridgeClient.Messages.Sensor
{
public class Illuminance : Message
{
[JsonIgnore]
public const string RosMessageName = "sensor_msgs/Illuminance";
public Standard.Header header;
public float illuminance;
public float variance;
}
}
