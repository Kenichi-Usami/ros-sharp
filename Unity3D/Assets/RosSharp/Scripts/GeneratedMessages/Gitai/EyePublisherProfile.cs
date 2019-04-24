/*
* DO NOT EDIT MANUALLY.
* This file is automatically generrated by gitai_msgs/generate_csharp.py
*/
using Newtonsoft.Json;
namespace RosSharp.RosBridgeClient.Messages.Gitai
{
public class EyePublisherProfile : Message
{
[JsonIgnore]
public const string RosMessageName = "gitai_msgs/EyePublisherProfile";
public Standard.Header header;
public Standard.Duration left_camera_publish;
public Standard.Duration left_rear_camera_publish;
public Standard.Duration left_front_camera_publish;
public Standard.Duration right_camera_publish;
public Standard.Duration right_rear_camera_publish;
public Standard.Duration right_front_camera_publish;
public Standard.Duration stereo_camera_publish;
}
}
