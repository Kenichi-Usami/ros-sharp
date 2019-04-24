/*
* DO NOT EDIT MANUALLY.
* This file is automatically generrated by gitai_msgs/generate_csharp.py
*/
using Newtonsoft.Json;
namespace RosSharp.RosBridgeClient.Messages.Gitai
{
public class FootPedal : Message
{
[JsonIgnore]
public const string RosMessageName = "gitai_msgs/FootPedal";
public Standard.Header header;
public bool left_pedal_pressed;
public bool center_pedal_pressed;
public bool right_pedal_pressed;
}
}
