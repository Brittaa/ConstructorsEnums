using System;

namespace DogBreedEnum
{
    enum Breed //tõugude nimed
    {
        Bulldog,
        Boxer,
        Chihauha

    }
    class Dog
    {
        public static int Count = 0;
        public string name;
        public int age;
        public Breed breed; //enum
        public Dog(string _name, int _age, Breed _breed) //konstruktor
        {
            name = _name;
            age = _age;
            breed = _breed;

            Count++;
        }
        public void PrintDogInfo()
        {
            Console.WriteLine($"Dog's name: {name}");
            Console.WriteLine($"Dog's age: {age}");
            Console.WriteLine($"Dog's breed: {breed}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog sass = new Dog("Sass", 10, Breed.Chihauha);
            sass.PrintDogInfo();
            Dog muki = new Dog("Muki", 2, Breed.Boxer);
            muki.PrintDogInfo();

            Console.WriteLine($"{Dog.Count} have been created.");
            Console.WriteLine((int)Breed.Boxer);//kasting
        }
    }
}
