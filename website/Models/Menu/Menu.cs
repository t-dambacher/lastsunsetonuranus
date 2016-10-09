using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LSOU.Web.Models.Menu
{
    public class Menu : IEnumerable<MenuItem>
    {
        private static readonly Menu _current = CreateNewMenu();
        public static Menu Current
        {
            get { return _current; }
        }

        private static Menu CreateNewMenu()
        {
            return new Menu()
            {
                { "Actualités", "Actualites" },
                { "Musique" },
                { "Vidéos", "Videos" },
                { "Presse" },
                { "Contacts" }
            };
        }

        private readonly IList<MenuItem> _items;
        
        private Menu()
        {
            this._items = new List<MenuItem>();
        }

        private void Add(MenuItem item)
        {
            _items.Add(item);
        }

        private void Add(String displayName)
        {
            Add(new MenuItem(GetNextOrder(), displayName));
        }

        private void Add(String displayName, String contentViewName)
        {
            Add(new MenuItem(GetNextOrder(), displayName, contentViewName));
        }

        private Int32 GetNextOrder()
        {
            return this._items.Count + 1;
        }

        public IEnumerator<MenuItem> GetEnumerator()
        {
            return this._items.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public MenuItem GetDefaultItem()
        {
            return this.OrderBy(i => i.Order).First();
        }
    }
}
