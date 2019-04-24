/*
* DO NOT EDIT MANUALLY.
* This file is automatically generrated by gitai_msgs/generate_csharp.py
*/
using Newtonsoft.Json;
namespace RosSharp.RosBridgeClient.Messages.Navigation
{
public class GridCells : Message
{
[JsonIgnore]
public const string RosMessageName = "nav_msgs/GridCells";
public Standard.Header header;
public float cell_width;
public float cell_height;
public Geometry.Point cells;
}
}
