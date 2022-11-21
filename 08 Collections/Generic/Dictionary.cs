using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericsDemo
{
    class Program
    {
        static void Main()
        {
            //Creating a Dictionary with Key and value both are string type using Collection Initializer
            Dictionary<string, string> dictionaryCountries = new Dictionary<string, string>
            {
                { "UK", "United Kingdom" },
                { "USA", "United State of America" },
                { "IND", "India" },
                { "PAK", "Pakistan" },
                { "SL", "Srilanka" }
            };

            Console.WriteLine($"Dictionary Elements Count Before Removing: {dictionaryCountries.Count}");
            foreach (var item in dictionaryCountries)
            {
                Console.WriteLine($"Key:{item.Key}, Value:{item.Value}");
            }

            // Remove element PAK from Dictionary Using Remove() method
            if (dictionaryCountries.ContainsKey("PAK"))
            {
                dictionaryCountries.Remove("PAK");
                Console.WriteLine($"\nDictionary Elements Count After Removing PAK: {dictionaryCountries.Count}");
                foreach (var item in dictionaryCountries)
                {
                    Console.WriteLine($"Key:{item.Key}, Value:{item.Value}");
                }
            }

            // Remove all Elements from Dictionary Using Clear method
            dictionaryCountries.Clear();
            Console.WriteLine($"\nDictionary Elements Count After Clear: {dictionaryCountries.Count}");


            //Generic Dictionary Collection with Complex Type in C#:

            Dictionary<int, Student> dictionaryStudents = new Dictionary<int, Student>
            {
                { 101, new Student(){ ID = 101, Name ="Ali", Branch="see"} },
                { 102, new Student(){ ID = 102, Name ="Ahmed", Branch="dcs"} },
                { 103, new Student(){ ID = 103, Name ="Mohammad", Branch="bcs"}},
                //The following Statement will give runtime error
                //System.ArgumentException: 'An item with the same key has already been added. Key: 101'
                //{ 101, new Student(){ ID = 101, Name ="Anurag", Branch="CSE"}}
            };
            foreach (KeyValuePair<int, Student> item in dictionaryStudents)
            {
                Console.WriteLine($"Key: {item.Key}, ID: {item.Value.ID}, Name: {item.Value.Name}, Branch: {item.Value.Branch}");
            }


            Student std102;
            if (dictionaryStudents.TryGetValue(102, out std102))
            {
                Console.WriteLine("\nStudent with Key = 102 is found in the dictionary");
                Console.WriteLine($"ID: {std102.ID}, Name: {std102.Name}, Branch: {std102.Branch}");
            }
            else
            {
                Console.WriteLine("\nStudent with Key = 102 is not found in the dictionary");
            }

            Student std105;
            if (dictionaryStudents.TryGetValue(105, out std105))
            {
                Console.WriteLine("\nStudent with Key = 102 is found in the dictionary");
                Console.WriteLine($"ID: {std105.ID}, Name: {std105.Name}, Branch: {std105.Branch}");
            }
            else
            {
                Console.WriteLine("\nStudent with Key = 105 is not found in the dictionary");
            }
            Console.ReadKey();
        }
    }


    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Branch { get; set; }
    }
}