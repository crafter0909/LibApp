using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Serializable]
    public class Journal : Lib
    {
        public Journal(string name, int pages, string author) : base("Журнал", name, pages, author) { }
    }
}
