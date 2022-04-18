using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp.Challenges.stack_queue_animal_shelter
{
    public class AnimalShelter
    {
        public AnimalNode Front { get; set; }
        public AnimalNode Rear { get; set; }
        public AnimalShelter()
        {
            Front = null;

        }

        public void Enqueue(AnimalNode NewAnimal)
        {

            if (NewAnimal.Type == "Cat" || NewAnimal.Type == "cat" )
            {

                if (Front == null)
                {
                    Front = NewAnimal;
                    Rear = NewAnimal;
                }
                else
                {
                    Rear.Next = NewAnimal;
                    Rear = NewAnimal;
                }

            }
            else if(NewAnimal.Type == "Dog" || NewAnimal.Type == "dog")
            {
                if (Front == null)
                {
                    Front = NewAnimal;
                    Rear = NewAnimal;
                }
                else
                {
                    Rear.Next = NewAnimal;
                    Rear = NewAnimal;
                }

            }
            else
            {
                Console.WriteLine("This Shleter hold only Cats and Dogs");
            }


        }
        public string Dequeue(string pref)
        {
            if (IsEmpty())
            { return null;}
                

            if (pref == "Cat" || pref == "cat" )
            {
                AnimalNode temp = Front;
                Front = Front.Next;
                temp.Next = null;
                return temp.Name;
            }
            else if (pref == "Dog" || pref == "dog")
            {
                AnimalNode temp = Front;
                Front = Front.Next;
                temp.Next = null;
                return temp.Name;

            }
            else return null;

        }
        public bool IsEmpty()
        {
            return Front == null;
        }
        public AnimalNode Peek()
        {
            if (IsEmpty())
            {
                throw new Exception("The AnimalShelter is empty!");
            }
            else

            {
                return Front;
            }

        }

    }
}
