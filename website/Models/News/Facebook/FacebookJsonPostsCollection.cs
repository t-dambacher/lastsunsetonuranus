using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LSOU.Web.Models.News.Facebook
{
    public class FacebookJsonPostsCollection
    {
        [JsonProperty("data")]
        public FacebookJsonPost[] Data { get; set; }

        public FacebookJsonPostsCollection()
        {
            this.Data = new FacebookJsonPost[0];
        }

        public IList<FacebookJsonPost> ToList()
        {
            return (this.Data ?? Enumerable.Empty<FacebookJsonPost>()).ToList();
        }
    }
}
