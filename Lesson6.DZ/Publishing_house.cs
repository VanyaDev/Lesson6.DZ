using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6.DZ
{
    class Publishing_house
    {
        private string PublHouse;

        public Publishing_house(string v)
        {
            PublHouse = v; 
        }

        public string PublishHouse { get => PublHouse; set => PublHouse = value; }
    }
}
