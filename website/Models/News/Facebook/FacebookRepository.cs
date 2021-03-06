﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;

namespace LSOU.Web.Models.News.Facebook
{
    public class FacebookRepository : INewsRepository
    {
        private static readonly Int32 _numberofFeeds = 10;
        private static readonly String _accessToken = ConfigurationManager.AppSettings["FacebookAccessToken"];
        private static readonly String _feedRequestUrl = "https://graph.facebook.com/v2.8/lastsunsetonuranus/posts?limit=" + _numberofFeeds + "&locale=fr&access_token=" + _accessToken;

        public FacebookRepository()
        { }

        public IEnumerable<FacebookJsonPost> GetLatestPosts()
        {
            HttpWebRequest feedRequest = (HttpWebRequest)WebRequest.Create(_feedRequestUrl);
            feedRequest.Method = "GET";
            feedRequest.Accept = "application/json";
            feedRequest.ContentType = "application/json; charset=utf-8";

            using (WebResponse feedResponse = (HttpWebResponse)feedRequest.GetResponse())
            {
                using (StreamReader reader = new StreamReader(feedResponse.GetResponseStream()))
                {
                    return JsonConvert.DeserializeObject<FacebookJsonPostsCollection>(reader.ReadToEnd()).ToList();
                }
            }
        }

        IEnumerable<News> INewsRepository.GetLatestPosts()
        {
            return GetLatestPosts().Select(n => new FacebookNews(n)).ToList();
        }
    }
}
