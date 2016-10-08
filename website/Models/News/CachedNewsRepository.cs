using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Text;
using System.Threading.Tasks;

namespace LSOU.Web.Models.News
{
    public class CachedNewsRepository : INewsRepository
    {
        private readonly INewsRepository _decorated;
        private readonly MemoryCache _cache;

        public CachedNewsRepository(INewsRepository decorated)
        {
            this._decorated = decorated;
            this._cache = MemoryCache.Default;
        }

        public IEnumerable<News> GetLatestPosts()
        {
            const String cacheKey = "LatestPost";
            IEnumerable<News> res = this._cache.Get(cacheKey) as IEnumerable<News>;
            if (res == null)
            {
                res = this._decorated.GetLatestPosts();
                this._cache.Add(cacheKey, res, DateTimeOffset.Now.Add(TimeSpan.FromHours(2)));
            }

            return res ?? Enumerable.Empty<News>();
        }
    }
}
