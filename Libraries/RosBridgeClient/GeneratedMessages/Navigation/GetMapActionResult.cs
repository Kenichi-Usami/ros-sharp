/*
* DO NOT EDIT MANUALLY.
* This file is automatically generrated by gitai_msgs/generate_csharp.py
*/
using Newtonsoft.Json;
namespace RosSharp.RosBridgeClient.Messages.Navigation
{
public class GetMapActionResult : Message
{
[JsonIgnore]
public const string RosMessageName = "nav_msgs/GetMapActionResult";
public Standard.Header header;
public Actionlib.GoalStatus status;
public Navigation.GetMapResult result;
}
}
