/*
* DO NOT EDIT MANUALLY.
* This file is automatically generrated by gitai_msgs/generate_csharp.py
*/
using Newtonsoft.Json;
namespace RosSharp.RosBridgeClient.Messages.Sensor
{
public class Imu : Message
{
[JsonIgnore]
public const string RosMessageName = "sensor_msgs/Imu";
public Standard.Header header;
public Geometry.Quaternion orientation;
public float orientation_covariance;
public Geometry.Vector3 angular_velocity;
public float angular_velocity_covariance;
public Geometry.Vector3 linear_acceleration;
public float linear_acceleration_covariance;
}
}
