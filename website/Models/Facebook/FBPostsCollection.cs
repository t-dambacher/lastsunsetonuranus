using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;

namespace LSOU.Web.Models.Facebook
{
    public class FBPostsCollection : IEnumerable<FBPost>
    {
        [JsonProperty("data")]
        public FBPost[] Data { get; set; }

        public FBPostsCollection()
        {
            this.Data = new FBPost[0];
        }

        public IEnumerator<FBPost> GetEnumerator()
        {
            return (IEnumerator<FBPost>)this.Data.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.Data.GetEnumerator();
        }
    }
}
