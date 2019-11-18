using System;

namespace DogConstructors
{
    class Animal
    {
        public static int Count = 0; // staatiline omadus

        public string name;//omadused
        public string color;
        public void PrintBasicInfo()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Color: {color}");
        }
    }
    class Dog: Animal
    {
        public string breed;
        //constructori loomine
        public Dog (string _name, string _color, string _breed)//sulgused omadused mis peavad olema
        {
            name = _name;
            color = _color;
            breed = _breed;

            Count++;
            //Console.WriteLine("A dog has been created!");
        }
        public void PrintDogInfo()
        {
            Console.WriteLine($"Dog's name: {name}");
            Console.WriteLine($"Dog's color: {color}");
            Console.WriteLine($"Dog's breed: {breed}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog rex = new Dog("Rex", "black and white", "husky");
            rex.PrintDogInfo();

            Console.WriteLine($"{Animal.Count} has/have been created.");//kõik loomad, mis loodud animal classi sees
        }
    }
}
