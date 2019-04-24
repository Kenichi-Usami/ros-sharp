/*
* DO NOT EDIT MANUALLY.
* This file is automatically generrated by gitai_msgs/generate_csharp.py
*/
using Newtonsoft.Json;
namespace RosSharp.RosBridgeClient.Messages.Visualization
{
public class InteractiveMarkerPose : Message
{
[JsonIgnore]
public const string RosMessageName = "visualization_msgs/InteractiveMarkerPose";
public Standard.Header header;
public Geometry.Pose pose;
public string name;
}
}
