/*
* DO NOT EDIT MANUALLY.
* This file is automatically generrated by gitai_msgs/generate_csharp.py
*/
using Newtonsoft.Json;
namespace RosSharp.RosBridgeClient.Messages.Sensor
{
public class FluidPressure : Message
{
[JsonIgnore]
public const string RosMessageName = "sensor_msgs/FluidPressure";
public Standard.Header header;
public float fluid_pressure;
public float variance;
}
}
