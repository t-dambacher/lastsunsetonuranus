using System;

namespace LSOU.Web.Models.Menu
{
    public class MenuItem
    {
        public Int32 Order { get; private set; }
        public String DisplayName { get; private set; }
        public String Name { get; private set; }
        public String Url { get; private set; }
        public String ContentViewName { get; private set; }

        public MenuItem(Int32 order, String displayName)
            : this(order, displayName, displayName)
        { }

        public MenuItem(Int32 order, String displayName, String contentViewName)
        {
            this.Order = order;
            this.DisplayName = displayName;
            this.Url = contentViewName + "/";
            this.Name = contentViewName;
            this.ContentViewName = "_" + contentViewName;
        }
    }
}
