using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6.DZ
{
    class Program
    {
        static void Main(string[] args)
        {
            Book name = new Book("Harry Potter");

            Console.WriteLine(name.Name);

            Book genre = new Book("Fantasy");

            Console.WriteLine(genre.Name);

            Author author = new Author("Joanne Kathleen Rowling");

            Console.WriteLine(author.author);

            Publishing_house pbl = new Publishing_house("Machaona");

            Console.WriteLine(pbl.PublishHouse);
        }
    }
}
