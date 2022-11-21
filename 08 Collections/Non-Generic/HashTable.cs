using System;
using System.Collections;
namespace WeekTow._08_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating Hashtable collection with default constructor
            Hashtable hashtable = new Hashtable();

            //Adding elements to the Hash table using key value pair
            hashtable.Add("EId", 1001); //Here key is Eid and value is 1001
            hashtable.Add("Name", "James"); //Here key is Name and value is James
            hashtable.Add("Salary", 3500); //Here key is Salary and value is 3500
            hashtable.Add("Location", "Mumbai"); //Here key is Location and value is Mumbai
            hashtable.Add("EmailID", "a@a.com"); //Here key is EmailID and value is a@a.com

            //Printing the keys and their values using foreach loop
            Console.WriteLine("Printing Hashtable using Foreach Loop");
            foreach (object obj in hashtable.Keys)
            {
                Console.WriteLine(obj + " : " + hashtable[obj]);
            }
            //Or
            //foreach (DictionaryEntry de in hashtable)
            //{
            //    Console.WriteLine($"Key: {de.Key}, Value: {de.Value}");
            //}

            Console.WriteLine("\nPrinting Hashtable using Keys");
            //I want to print the Location by using the Location key
            Console.WriteLine("Location : " + hashtable["Location"]);

            //I want to print the Email ID by using the EmailID key
            Console.WriteLine("Emaild ID : " + hashtable["EmailID"]);

            Console.ReadKey();
        }
    }
}