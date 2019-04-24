/*
* DO NOT EDIT MANUALLY.
* This file is automatically generrated by gitai_msgs/generate_csharp.py
*/
using Newtonsoft.Json;
namespace RosSharp.RosBridgeClient.Messages.Gitai
{
public class DynamixelRamData : Message
{
[JsonIgnore]
public const string RosMessageName = "gitai_msgs/DynamixelRamData";
public Standard.Header header;
public uint torque_enable;
public uint velocity_i_gain;
public uint velocity_p_gain;
public uint position_p_gain;
public int goal_position;
public int goal_velocity;
public int goal_acceleration;
public int goal_current;
public uint moving;
public uint present_position;
public uint present_velocity;
public uint present_current;
public uint present_input_voltage;
public uint present_temperature;
public uint status_return_level;
public uint hardware_error_status;
public uint led_red;
public uint led_green;
public uint led_blue;
public uint led;
public uint registered_instruction;
public uint position_d_gain;
public uint position_i_gain;
public uint feedforward_2nd_gain;
public uint feedforward_1st_gain;
public uint bus_watchdog;
public int goal_pwm;
public uint profile_acceleration;
public uint profile_velocity;
public uint realtime_tick;
public uint moving_status;
public uint velocity_trajectory;
public uint position_trajectory;
}
}
