/*
* DO NOT EDIT MANUALLY.
* This file is automatically generrated by gitai_msgs/generate_csharp.py
*/
using Newtonsoft.Json;
namespace RosSharp.RosBridgeClient.Messages.Navigation
{
public class GetMapActionGoal : Message
{
[JsonIgnore]
public const string RosMessageName = "nav_msgs/GetMapActionGoal";
public Standard.Header header;
public Actionlib.GoalID goal_id;
public Navigation.GetMapGoal goal;
}
}
