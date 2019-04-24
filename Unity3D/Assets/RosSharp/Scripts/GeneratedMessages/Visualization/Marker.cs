/*
* DO NOT EDIT MANUALLY.
* This file is automatically generrated by gitai_msgs/generate_csharp.py
*/
using Newtonsoft.Json;
namespace RosSharp.RosBridgeClient.Messages.Visualization
{
public class Marker : Message
{
[JsonIgnore]
public const string RosMessageName = "visualization_msgs/Marker";
public Standard.Header header;
public string ns;
public int id;
public int type;
public int action;
public Geometry.Pose pose;
public Geometry.Vector3 scale;
public Standard.ColorRGBA color;
public Standard.Duration lifetime;
public bool frame_locked;
public Geometry.Point points;
public Standard.ColorRGBA colors;
public string text;
public string mesh_resource;
public bool mesh_use_embedded_materials;
}
}
