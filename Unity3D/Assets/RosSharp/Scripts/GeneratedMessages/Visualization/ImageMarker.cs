/*
* DO NOT EDIT MANUALLY.
* This file is automatically generrated by gitai_msgs/generate_csharp.py
*/
using Newtonsoft.Json;
namespace RosSharp.RosBridgeClient.Messages.Visualization
{
public class ImageMarker : Message
{
[JsonIgnore]
public const string RosMessageName = "visualization_msgs/ImageMarker";
public Standard.Header header;
public string ns;
public int id;
public int type;
public int action;
public Geometry.Point position;
public float scale;
public Standard.ColorRGBA outline_color;
public uint filled;
public Standard.ColorRGBA fill_color;
public Standard.Duration lifetime;
public Geometry.Point points;
public Standard.ColorRGBA outline_colors;
}
}
