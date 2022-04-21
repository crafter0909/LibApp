using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Serializable]
    public class Book : Lib
    {
        public Book(string name, int pages, string author) : base("Книга", name, pages, author) { }
    }
}
