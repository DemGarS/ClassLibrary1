using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
 
    

        public class Person
        {
            public string Name { get; set; }
            public string Address { get; set; }
            public List<Hobby> Hobbies { get; private set; } = new List<Hobby>();
            public void AddHobby(Hobby hobby)
            {
                Hobbies.Add(hobby);
            }
            public void ShowAll()
            {
                foreach (var hobby in Hobbies.OrderBy(h => h.Name)) //garshin 34IS
                {
                    hobby.Show();
                }
            }
        }
    }
    public class Hobby
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public void Show()
        {
            System.Console.WriteLine($"Название: {Name}, Описание: {Description}");
        }
    }



