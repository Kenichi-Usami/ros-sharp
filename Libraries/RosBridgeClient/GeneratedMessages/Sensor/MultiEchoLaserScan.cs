/*
* DO NOT EDIT MANUALLY.
* This file is automatically generrated by gitai_msgs/generate_csharp.py
*/
using Newtonsoft.Json;
namespace RosSharp.RosBridgeClient.Messages.Sensor
{
public class MultiEchoLaserScan : Message
{
[JsonIgnore]
public const string RosMessageName = "sensor_msgs/MultiEchoLaserScan";
public Standard.Header header;
public float angle_min;
public float angle_max;
public float angle_increment;
public float time_increment;
public float scan_time;
public float range_min;
public float range_max;
public Sensor.LaserEcho ranges;
public Sensor.LaserEcho intensities;
}
}
