/*
* DO NOT EDIT MANUALLY.
* This file is automatically generrated by gitai_msgs/generate_csharp.py
*/
using Newtonsoft.Json;
namespace RosSharp.RosBridgeClient.Messages.Sensor
{
public class TimeReference : Message
{
[JsonIgnore]
public const string RosMessageName = "sensor_msgs/TimeReference";
public Standard.Header header;
public Standard.Time time_ref;
public string source;
}
}
