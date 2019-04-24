/*
* DO NOT EDIT MANUALLY.
* This file is automatically generrated by gitai_msgs/generate_csharp.py
*/
using Newtonsoft.Json;

namespace RosSharp.RosBridgeClient.Messages.Standard
{
    public class Duration : Message
    {
        [JsonIgnore]
        public const string RosMessageName = "std_msgs/Duration";
        public int secs;
        public int nsecs;
    }
}

    