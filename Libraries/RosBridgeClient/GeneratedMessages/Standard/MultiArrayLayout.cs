/*
* DO NOT EDIT MANUALLY.
* This file is automatically generrated by gitai_msgs/generate_csharp.py
*/
using Newtonsoft.Json;
namespace RosSharp.RosBridgeClient.Messages.Standard
{
public class MultiArrayLayout : Message
{
[JsonIgnore]
public const string RosMessageName = "std_msgs/MultiArrayLayout";
public Standard.MultiArrayDimension dim;
public uint data_offset;
}
}
