using System;
using Xunit;
using ConsoleApp.Challenges.stack_queue_animal_shelter;
namespace TestStack_queue_animal_shelter
{
    public class TestShleter
    {
        AnimalShelter MyNewAnimalShleter = new AnimalShelter();
        //Test Enqueue multiple values
        [Fact]
        public void TestEnqueue()
        {
            AnimalNode node1 = new AnimalNode("Lolo Caty", "Cat", 4);
            AnimalNode node2 = new AnimalNode("Popy", "dog", 9);
            AnimalNode node3 = new AnimalNode("Loletta", "cat", 1);
            AnimalNode node4 = new AnimalNode("HaxyBob", "Dog", 4);
            MyNewAnimalShleter.Enqueue(node1);
            MyNewAnimalShleter.Enqueue(node2);
            MyNewAnimalShleter.Enqueue(node3);
            MyNewAnimalShleter.Enqueue(node4);
            Assert.Equal(node1, MyNewAnimalShleter.Peek());
        }

        //Test Enqueue single value
        [Fact]
        public void TestSingleEnqueue()
        {
            
            AnimalNode node2 = new AnimalNode("Popy", "dog", 9);
           
            MyNewAnimalShleter.Enqueue(node2);
            
            Assert.Equal(node2, MyNewAnimalShleter.Peek());
        }
        // Test Dequeue
        [Fact]
        public void TestDequeue()
        {
            AnimalNode node1 = new AnimalNode("Lolo Caty", "Cat", 4);
            AnimalNode node2 = new AnimalNode("Popy", "dog", 9);
            AnimalNode node3 = new AnimalNode("Loletta", "cat", 1);
            AnimalNode node4 = new AnimalNode("HaxyBob", "Dog", 4);
            MyNewAnimalShleter.Enqueue(node1);
            MyNewAnimalShleter.Enqueue(node2);
            MyNewAnimalShleter.Enqueue(node3);
            MyNewAnimalShleter.Enqueue(node4);

            Assert.Equal("cat", MyNewAnimalShleter.Dequeue("cat"));
        }
        // Test Enqueue Not Dog or Cat
        [Fact]
        public void TestEnqueueInvalidAnimal()
        {
            AnimalNode node1 = new AnimalNode("Hoursy", "Hourse", 4);
            MyNewAnimalShleter.Enqueue(node1);
            Assert.Null(MyNewAnimalShleter.Front);
        }
        // Test Dequeue Invalid animal
        [Fact]
        public void TestDequeueInvalidAnimal()
        {
            AnimalNode node1 = new AnimalNode("Loletta", "cat", 1);
            AnimalNode node2 = new AnimalNode("HaxyBob", "Dog", 4);
            MyNewAnimalShleter.Enqueue(node1);
            MyNewAnimalShleter.Enqueue(node2);
            Assert.Null(MyNewAnimalShleter.Dequeue("hourse"));
        }
        //test peek 
        [Fact]
        public void TestPeek()
        {
            AnimalNode node1 = new AnimalNode("Lolo Caty", "Cat", 4);
            AnimalNode node2 = new AnimalNode("Popy", "dog", 9);
            AnimalNode node3 = new AnimalNode("Loletta", "cat", 1);
            MyNewAnimalShleter.Enqueue(node1);
            MyNewAnimalShleter.Enqueue(node2);
            MyNewAnimalShleter.Enqueue(node3);
            
            Assert.Equal(node1, MyNewAnimalShleter.Peek());

        }
        // test  Dequeue on   EmptyQueue will rturn null like lab requerment
        [Fact]
        public void TestDequeueInEmptyQueue()
        {
            Assert.Null( MyNewAnimalShleter.Dequeue("cat"));
        }
        //test Enqueue in empty Queue
        [Fact]
        public void TestEnqueueOnEmptyQueue()
        {
            AnimalShelter TestShleter = new AnimalShelter();
            AnimalNode node1 = new AnimalNode("Lolo Caty", "Cat", 4);

            TestShleter.Enqueue(node1);
            Assert.Equal(node1, TestShleter.Peek());

        }





    }
}
