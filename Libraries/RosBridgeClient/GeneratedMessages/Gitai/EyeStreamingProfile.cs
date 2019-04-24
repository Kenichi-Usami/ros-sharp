/*
* DO NOT EDIT MANUALLY.
* This file is automatically generrated by gitai_msgs/generate_csharp.py
*/
using Newtonsoft.Json;
namespace RosSharp.RosBridgeClient.Messages.Gitai
{
public class EyeStreamingProfile : Message
{
[JsonIgnore]
public const string RosMessageName = "gitai_msgs/EyeStreamingProfile";
public Standard.Header header;
public int camera_fps;
public Standard.Duration camera_open;
public Standard.Duration camera_open_1;
public Standard.Duration camera_open_2;
public Standard.Duration retrieve_camera;
public Standard.Duration retrieve_camera_copy_image1;
public Standard.Duration retrieve_camera_copy_image2;
public Standard.Duration retrieve_camera_stereo_make_image;
public Standard.Duration retrieve_camera_stereo_image_queue;
public Standard.Duration retrieve_camera_end_process;
public Standard.Duration streaming_process;
public Standard.Duration streaming_init;
public Standard.Duration view_point_process;
public Standard.Duration view_point_process_make_image;
public Standard.Duration view_point_process_compress_image;
public Standard.Duration view_point_process_set_image_data;
public Standard.Duration view_point_process_send_image_data;
public Standard.Duration show_log;
public Standard.Duration end_process;
public Standard.Duration end_process_set_last_image;
public Standard.Duration end_process_set_header;
public Standard.Duration total;
}
}
