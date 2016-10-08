namespace LSOU.Web.Models.News.Facebook
{
    public sealed class FacebookNews : News
    {
        public FacebookNews(FacebookJsonPost post)
            : base(post.ID, post.Story, post.Message, post.CreatedTime)
        { }
    }
}
