/*
* DO NOT EDIT MANUALLY.
* This file is automatically generrated by gitai_msgs/generate_csharp.py
*/
using Newtonsoft.Json;
namespace RosSharp.RosBridgeClient.Messages.Gitai
{
public class EyeConfigState : Message
{
[JsonIgnore]
public const string RosMessageName = "gitai_msgs/EyeConfigState";
public Standard.Header header;
public int run_mode;
public int camera_frame_width;
public int camera_frame_height;
public int camera_lens_type;
public string send_ip_address;
public int send_port;
public int send_source_port;
public int receive_port;
public int encode_compression_level;
public bool is_internet;
public int send_packet_size;
}
}
