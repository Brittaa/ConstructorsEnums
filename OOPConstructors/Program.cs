using System;

namespace OOPConstructors
{
    class Animal
    {
        public string name;//omadused
        public int age;
        public int levelOfHappiness;
        public void PrintBasicInfo()//tegusõna, meetodid, nagu funktsioonid
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Level of happiness: {levelOfHappiness}");
        }
    }
    class Dog : Animal
    {
            public int numberOfBarks = 0;
            public void WaveTail()
            {
                levelOfHappiness ++;
            }
            public void Bark()
            {
                Console.WriteLine("Woof");
                numberOfBarks++;
            }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //lehvitab 12 korda saba, 3,6,9,12 korral haugub.
            Dog muki = new Dog();
            muki.name = "Muki";
            muki.age = 2;
            muki.levelOfHappiness = 0;
            muki.PrintBasicInfo();

            for (int i = 0; i < 12; i++)
            {
                muki.WaveTail();
                Console.WriteLine("Tailwave!");
                if (muki.levelOfHappiness % 3 == 0)
                {
                    muki.Bark();
                }
            }
            muki.PrintBasicInfo();
            Console.WriteLine($"{muki.name} has barked {muki.numberOfBarks} times.");
        }
    }
}
