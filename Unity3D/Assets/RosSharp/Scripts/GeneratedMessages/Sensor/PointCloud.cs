/*
* DO NOT EDIT MANUALLY.
* This file is automatically generrated by gitai_msgs/generate_csharp.py
*/
using Newtonsoft.Json;
namespace RosSharp.RosBridgeClient.Messages.Sensor
{
public class PointCloud : Message
{
[JsonIgnore]
public const string RosMessageName = "sensor_msgs/PointCloud";
public Standard.Header header;
public Geometry.Point32 points;
public Sensor.ChannelFloat32 channels;
}
}
