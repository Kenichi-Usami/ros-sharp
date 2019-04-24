/*
* DO NOT EDIT MANUALLY.
* This file is automatically generrated by gitai_msgs/generate_csharp.py
*/
using Newtonsoft.Json;
namespace RosSharp.RosBridgeClient.Messages.Gitai
{
public class OmniWheelDriverState : Message
{
[JsonIgnore]
public const string RosMessageName = "gitai_msgs/OmniWheelDriverState";
public Standard.Header header;
public int l_pulse;
public int r_pulse;
public int f_pulse;
public int l_current;
public int r_current;
public int f_current;
public int lr_error;
public int f_error;
}
}
