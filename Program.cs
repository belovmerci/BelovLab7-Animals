using System;
using System.Collections.Generic;
using System.Text;

namespace BelovLab7
{
    // Controller has animal creation and feeding in it
    class Controller
    {
        static void Feed(Animal animal, Food food)
        {
            animal.Eat(food);
        }

        public static void RunSim()
        {
            Cat cat = new Cat();
            Dog dog = new Dog();
            Horse horse = new Horse();

            Fish fish = new Fish();
            Bone bone = new Bone();
            Hay hay = new Hay();

            Feed(cat, fish);
            Feed(dog, bone);
            Feed(horse, hay);
        }
    }

    // Main Program
    class Program
    {
        static void Main(string[] args)
        {
            Controller.RunSim();
        }
    }
}
