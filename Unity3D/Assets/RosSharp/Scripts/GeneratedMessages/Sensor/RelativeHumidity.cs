/*
* DO NOT EDIT MANUALLY.
* This file is automatically generrated by gitai_msgs/generate_csharp.py
*/
using Newtonsoft.Json;
namespace RosSharp.RosBridgeClient.Messages.Sensor
{
public class RelativeHumidity : Message
{
[JsonIgnore]
public const string RosMessageName = "sensor_msgs/RelativeHumidity";
public Standard.Header header;
public float relative_humidity;
public float variance;
}
}
