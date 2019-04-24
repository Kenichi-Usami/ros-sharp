/*
* DO NOT EDIT MANUALLY.
* This file is automatically generrated by gitai_msgs/generate_csharp.py
*/
using Newtonsoft.Json;
namespace RosSharp.RosBridgeClient.Messages.Visualization
{
public class InteractiveMarkerControl : Message
{
[JsonIgnore]
public const string RosMessageName = "visualization_msgs/InteractiveMarkerControl";
public string name;
public Geometry.Quaternion orientation;
public uint orientation_mode;
public uint interaction_mode;
public bool always_visible;
public Visualization.Marker markers;
public bool independent_marker_orientation;
public string description;
}
}
