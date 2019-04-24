/*
* DO NOT EDIT MANUALLY.
* This file is automatically generrated by gitai_msgs/generate_csharp.py
*/
using Newtonsoft.Json;
namespace RosSharp.RosBridgeClient.Messages.Sensor
{
public class Temperature : Message
{
[JsonIgnore]
public const string RosMessageName = "sensor_msgs/Temperature";
public Standard.Header header;
public float temperature;
public float variance;
}
}
