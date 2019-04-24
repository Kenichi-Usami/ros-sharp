/*
* DO NOT EDIT MANUALLY.
* This file is automatically generrated by gitai_msgs/generate_csharp.py
*/
using Newtonsoft.Json;
namespace RosSharp.RosBridgeClient.Messages.Gitai
{
public class TemperatureState : Message
{
[JsonIgnore]
public const string RosMessageName = "gitai_msgs/TemperatureState";
public Standard.Header header;
public string name;
public float temperature;
}
}
