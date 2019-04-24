/*
* DO NOT EDIT MANUALLY.
* This file is automatically generrated by gitai_msgs/generate_csharp.py
*/
using Newtonsoft.Json;
namespace RosSharp.RosBridgeClient.Messages.Visualization
{
public class InteractiveMarkerUpdate : Message
{
[JsonIgnore]
public const string RosMessageName = "visualization_msgs/InteractiveMarkerUpdate";
public string server_id;
public uint seq_num;
public uint type;
public Visualization.InteractiveMarker markers;
public Visualization.InteractiveMarkerPose poses;
public string erases;
}
}
