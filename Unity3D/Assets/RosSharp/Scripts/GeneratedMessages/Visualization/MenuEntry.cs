/*
* DO NOT EDIT MANUALLY.
* This file is automatically generrated by gitai_msgs/generate_csharp.py
*/
using Newtonsoft.Json;
namespace RosSharp.RosBridgeClient.Messages.Visualization
{
public class MenuEntry : Message
{
[JsonIgnore]
public const string RosMessageName = "visualization_msgs/MenuEntry";
public uint id;
public uint parent_id;
public string title;
public string command;
public uint command_type;
}
}
