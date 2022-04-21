using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Serializable]
    public class Digest : Lib
    {
        public Digest(string name, int pages, string author) : base("Сборник", name, pages, author) { }
    }
}
