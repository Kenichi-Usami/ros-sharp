/*
* DO NOT EDIT MANUALLY.
* This file is automatically generrated by gitai_msgs/generate_csharp.py
*/
using Newtonsoft.Json;
namespace RosSharp.RosBridgeClient.Messages.Visualization
{
public class InteractiveMarkerFeedback : Message
{
[JsonIgnore]
public const string RosMessageName = "visualization_msgs/InteractiveMarkerFeedback";
public Standard.Header header;
public string client_id;
public string marker_name;
public string control_name;
public uint event_type;
public Geometry.Pose pose;
public uint menu_entry_id;
public Geometry.Point mouse_point;
public bool mouse_point_valid;
}
}
