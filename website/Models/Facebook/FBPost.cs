﻿using Newtonsoft.Json;
using System;

namespace LSOU.Web.Models.Facebook
{
    public class FBPost
    {
        [JsonProperty("message")]
        public String Message { get; set; }

        [JsonProperty("story")]
        public String Story { get; set; }

        [JsonProperty("created_time")]
        public DateTime CreatedTime { get; set; }

        [JsonProperty("id")]
        public String ID { get; set; }
    }
}
