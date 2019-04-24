/*
* DO NOT EDIT MANUALLY.
* This file is automatically generrated by gitai_msgs/generate_csharp.py
*/
using Newtonsoft.Json;
namespace RosSharp.RosBridgeClient.Messages.Navigation
{
public class GetMapActionFeedback : Message
{
[JsonIgnore]
public const string RosMessageName = "nav_msgs/GetMapActionFeedback";
public Standard.Header header;
public Actionlib.GoalStatus status;
public Navigation.GetMapFeedback feedback;
}
}
