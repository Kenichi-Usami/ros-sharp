/*
* DO NOT EDIT MANUALLY.
* This file is automatically generrated by gitai_msgs/generate_csharp.py
*/
using Newtonsoft.Json;
namespace RosSharp.RosBridgeClient.Messages.Sensor
{
public class CameraInfo : Message
{
[JsonIgnore]
public const string RosMessageName = "sensor_msgs/CameraInfo";
public Standard.Header header;
public uint height;
public uint width;
public string distortion_model;
public float D;
public float K;
public float R;
public float P;
public uint binning_x;
public uint binning_y;
public Sensor.RegionOfInterest roi;
}
}
