using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace ListOfObjects
{
    class Person
    {
        public static int Count = 0;
        public string firtsName; //{ get; set; } konstruktor, lubab määrata väärtused
        public string lastName;
        public int age;

        public Person(string _firstName, string _lastName, int _age)
        {
            firtsName = _firstName;
            lastName = _lastName;
            age = _age;
            Count++;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*string filePath = @"/Users/Britta/Demo/item.txt";
            List<string> lines = File.ReadAllLines(filePath).ToList();

            foreach(string line in lines)
            {
                Console.WriteLine($"{line}");
            }*/

            string filePath = @"/Users/Britta/Demo/People.txt";
            List<string> listOfPeople = File.ReadAllLines(filePath).ToList();
            List<Person> listOfPersonObjects = new List<Person>();

            foreach (string line in listOfPeople)
            {
                string[] tempArray = line.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                Person newPerson = new Person(tempArray[0], tempArray[1], int.Parse(tempArray[2])); //lõime objekti
                listOfPersonObjects.Add(newPerson); //lisasime listi
            }

            foreach(Person person in listOfPersonObjects)
            {
                Console.WriteLine($"{person.firtsName} {person.lastName} age {person.age} is on your list.");
            }
         
            //Peab olema txt fail nimekirjal, muidu ei tööta mac-il!!!!!

        }
    }
}
