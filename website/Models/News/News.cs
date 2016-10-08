using System;

namespace LSOU.Web.Models.News
{ 
    public abstract class News : IEquatable<News>
    {
        public String ID { get; private set; }
        public String Title { get; private set; }
        public String Content { get; private set; }
        public DateTime CreatedTime { get; private set; }

        protected News(String id, String title, String content, DateTime createdTime)
        {
            this.ID = id;
            this.Title = title;
            this.Content = content;
            this.CreatedTime = createdTime;
        }

        public Boolean IsValid()
        {
            return !String.IsNullOrWhiteSpace(this.Content) && this.CreatedTime != DateTime.MinValue;
        }

        public override Boolean Equals(Object obj)
        {
            return Equals(obj as News);
        }

        public Boolean Equals(News other)
        {
            return other != null && this.ID == other.ID && this.CreatedTime == other.CreatedTime;
        }

        public override Int32 GetHashCode()
        {
            return this.ID.GetHashCode() ^ this.CreatedTime.GetHashCode();
        }
    }
}
