/*
* DO NOT EDIT MANUALLY.
* This file is automatically generrated by gitai_msgs/generate_csharp.py
*/
using Newtonsoft.Json;
namespace RosSharp.RosBridgeClient.Messages.Sensor
{
public class RegionOfInterest : Message
{
[JsonIgnore]
public const string RosMessageName = "sensor_msgs/RegionOfInterest";
public uint x_offset;
public uint y_offset;
public uint height;
public uint width;
public bool do_rectify;
}
}
