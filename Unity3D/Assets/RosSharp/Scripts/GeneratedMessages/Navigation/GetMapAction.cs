/*
* DO NOT EDIT MANUALLY.
* This file is automatically generrated by gitai_msgs/generate_csharp.py
*/
using Newtonsoft.Json;
namespace RosSharp.RosBridgeClient.Messages.Navigation
{
public class GetMapAction : Message
{
[JsonIgnore]
public const string RosMessageName = "nav_msgs/GetMapAction";
public Navigation.GetMapActionGoal action_goal;
public Navigation.GetMapActionResult action_result;
public Navigation.GetMapActionFeedback action_feedback;
}
}
