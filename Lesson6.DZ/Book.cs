using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6.DZ
{
    class Book
    {
        private string _name;
        private string _genre;

        public Book(string v)
        {
            _name = v;
        }

        public string Name { get => _name; set => _name = value; }
        public string Genre { get => _genre; set => _genre = value; }
    }
}
