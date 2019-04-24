/*
* DO NOT EDIT MANUALLY.
* This file is automatically generrated by gitai_msgs/generate_csharp.py
*/
using Newtonsoft.Json;
namespace RosSharp.RosBridgeClient.Messages.Visualization
{
public class InteractiveMarker : Message
{
[JsonIgnore]
public const string RosMessageName = "visualization_msgs/InteractiveMarker";
public Standard.Header header;
public Geometry.Pose pose;
public string name;
public string description;
public float scale;
public Visualization.MenuEntry menu_entries;
public Visualization.InteractiveMarkerControl controls;
}
}
