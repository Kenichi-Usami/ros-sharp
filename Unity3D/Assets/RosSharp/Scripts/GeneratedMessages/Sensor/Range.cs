/*
* DO NOT EDIT MANUALLY.
* This file is automatically generrated by gitai_msgs/generate_csharp.py
*/
using Newtonsoft.Json;
namespace RosSharp.RosBridgeClient.Messages.Sensor
{
public class Range : Message
{
[JsonIgnore]
public const string RosMessageName = "sensor_msgs/Range";
public Standard.Header header;
public uint radiation_type;
public float field_of_view;
public float min_range;
public float max_range;
public float range;
}
}
