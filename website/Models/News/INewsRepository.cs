using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSOU.Web.Models.News
{
    public interface INewsRepository
    {
        IEnumerable<News> GetLatestPosts();
    }
}
