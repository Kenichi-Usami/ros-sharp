/*
* DO NOT EDIT MANUALLY.
* This file is automatically generrated by gitai_msgs/generate_csharp.py
*/
using Newtonsoft.Json;
namespace RosSharp.RosBridgeClient.Messages.Gitai
{
public class EyeCaptureProfile : Message
{
[JsonIgnore]
public const string RosMessageName = "gitai_msgs/EyeCaptureProfile";
public Standard.Header header;
public Standard.Duration camera_capture_1;
public Standard.Duration camera_capture_2;
public Standard.Duration camera_open;
public Standard.Duration total_camera_capture;
public Standard.Duration queue_operation;
}
}
