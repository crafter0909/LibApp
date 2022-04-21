using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public abstract class Lib
    {
        public string Name { get; set; }
        public string LibName { get; set; }
        public int Pages { get; set; }
        public string Author { get; set; }

        protected Lib(string libName, string name, int pages, string author)
        {
            if (pages <= 0)
            {
                throw new Exception("Страниц должно быть > 0");
            }

            Name = name;
            LibName = libName;
            Pages = pages;
            Author = author;
        }

        public string Format()
        {
            return $"{LibName}: название - {Name}, автор - {Author}, страниц - {Pages}";
        }
    }
}
