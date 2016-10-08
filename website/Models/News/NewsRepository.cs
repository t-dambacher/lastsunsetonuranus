using LSOU.Web.Models.News.Facebook;
using System.Collections.Generic;

namespace LSOU.Web.Models.News
{
    public sealed class NewsRepository : INewsRepository
    {
        private static readonly INewsRepository _current = new NewsRepository();

        public static IEnumerable<News> GetLatestPosts()
        {
            return _current.GetLatestPosts();
        }

        private readonly INewsRepository _decorated;

        private NewsRepository()
        {
            this._decorated = new CachedNewsRepository(
                new FacebookRepository()
            );
        }

        IEnumerable<News> INewsRepository.GetLatestPosts()
        {
            return this._decorated.GetLatestPosts();
        }
    }
}
