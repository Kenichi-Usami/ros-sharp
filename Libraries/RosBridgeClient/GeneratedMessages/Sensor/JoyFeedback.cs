/*
* DO NOT EDIT MANUALLY.
* This file is automatically generrated by gitai_msgs/generate_csharp.py
*/
using Newtonsoft.Json;
namespace RosSharp.RosBridgeClient.Messages.Sensor
{
public class JoyFeedback : Message
{
[JsonIgnore]
public const string RosMessageName = "sensor_msgs/JoyFeedback";
public uint type;
public uint id;
public float intensity;
}
}
