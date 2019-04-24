/*
* DO NOT EDIT MANUALLY.
* This file is automatically generrated by gitai_msgs/generate_csharp.py
*/
using Newtonsoft.Json;
namespace RosSharp.RosBridgeClient.Messages.Sensor
{
public class MultiDOFJointState : Message
{
[JsonIgnore]
public const string RosMessageName = "sensor_msgs/MultiDOFJointState";
public Standard.Header header;
public string joint_names;
public Geometry.Transform transforms;
public Geometry.Twist twist;
public Geometry.Wrench wrench;
}
}
