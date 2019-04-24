/*
* DO NOT EDIT MANUALLY.
* This file is automatically generrated by gitai_msgs/generate_csharp.py
*/
using Newtonsoft.Json;
namespace RosSharp.RosBridgeClient.Messages.Visualization
{
public class InteractiveMarkerInit : Message
{
[JsonIgnore]
public const string RosMessageName = "visualization_msgs/InteractiveMarkerInit";
public string server_id;
public uint seq_num;
public Visualization.InteractiveMarker markers;
}
}
