using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp.Challenges;
using stack_and_queue.Classes;

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

        public void Enqueue(AnimalNode NodeAnimal)
        {

            if (NodeAnimal.Type == "cat" || NodeAnimal.Type == "dog")
            {

                
                if (Front == null)
                {
                    Front = NodeAnimal;
                    Rear = NodeAnimal;
                }
                else
                {
                    Rear.Next = NodeAnimal;
                    Rear = NodeAnimal;
                }
            }
            else if (NodeAnimal.Type != "cat" || NodeAnimal.Type != "dog")
            {
                Console.WriteLine("This Shleter hold only Cats and Dogs");
            }
        }

        public string Dequeue(string pref)

        {
            AnimalNode temp = Front;
            if (IsEmpty())
            { return null; }

            if (pref.ToLower() == "cat" || pref.ToLower() == "dog")
            {

                temp = Front;
                if (temp.Type == pref.ToLower())
                {
                    Front = Front.Next;
                    temp.Next = null;
                    return temp.Type;
                }
                else
                {
                    while (temp.Next != null)
                    {
                        if (temp.Next.Type==pref.ToLower())
                        {
                            AnimalNode Result = temp.Next;
                            temp.Next = temp.Next.Next;
                            return Result.Type;
                        }
                        temp = temp.Next;  
                    }
                }
                return null;
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
        public void toString()
        {
            AnimalNode current = Front;
            while (current.Next != null)
            {
                Console.Write($"{current.Name}->");
                current = current.Next;
            }
            Console.Write($"{current.Name}->");
            Console.Write("NULL");
            Console.WriteLine();
        }

    }
}

