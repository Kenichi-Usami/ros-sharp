/*
* DO NOT EDIT MANUALLY.
* This file is automatically generrated by gitai_msgs/generate_csharp.py
*/
using Newtonsoft.Json;
namespace RosSharp.RosBridgeClient.Messages.Sensor
{
public class BatteryState : Message
{
[JsonIgnore]
public const string RosMessageName = "sensor_msgs/BatteryState";
public Standard.Header header;
public float voltage;
public float current;
public float charge;
public float capacity;
public float design_capacity;
public float percentage;
public uint power_supply_status;
public uint power_supply_health;
public uint power_supply_technology;
public bool present;
public float cell_voltage;
public string location;
public string serial_number;
}
}
