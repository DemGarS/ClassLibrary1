using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                var person = new Person
                {
                    Name = "Иван Иванов",
                    Address = "Москва"
                };
                person.AddHobby(new Hobby { Name = "Чтение", Description = "Люблю читать книги" });
                person.AddHobby(new Hobby { Name = "Футбол", Description = "Играю в футбол по выходным" });
                person.AddHobby(new Hobby { Name = "Кино", Description = "Смотрю фильмы разных жанров" });
                person.ShowAll();
            }
            Console.Write("Гаршин 34ис");
            Console.ReadKey();

        }
    }
}
