using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6.DZ
{
    class Author
    {
        private string _author;

        public Author(string v)
        {
            _author = v;
        }

        public string author { get => _author; set => _author = value; }
    }
}
