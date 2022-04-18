using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Challenges.stack_queue_animal_shelter
{
    public class AnimalNode
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Age { get; set; }
        public AnimalNode Next { get; set;}

        public AnimalNode(string Name,string Type, int Age )
        {
            this.Type = Type;
            this.Name = Name;
            this.Age = Age;
            Next = null;
        }
      
    }
}

