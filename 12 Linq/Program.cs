using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            
        
            var books = new BookRepository().GetBooks();
            linq query method
            var filterbooks = from book in books where book.Price > 3 select book;
            foreach (var item in filterbooks)
            {
                Console.WriteLine(item.Title);
            }
            extension method
            var filter = books.Where(x => x.Price > 3).OrderBy(x => x.Title);
            Console.WriteLine("extension method");
            var filter = books.Skip(2).Take(3);
            foreach (var item in filter)
            {
                Console.WriteLine(item.Title);
            }
            var max = books.Max(b=>b.Price);
            Console.WriteLine(max);
            var min = books.Min(b => b.Price);
            Console.WriteLine(min);
            var avg = books.Average(b => b.Price);
            Console.WriteLine(avg);
            var count = books.Count();
            Console.WriteLine(count);
            var cont = books.FirstOrDefault();
            Console.WriteLine(cont.Title);
            books.First();
           
            var book=books.Last();
            var book = books.Last(b => b.Price > 3);
            foreach (var item in book)
            {
                Console.WriteLine(item.Title);
            }
            Console.WriteLine(book.Title);
            Console.ReadKey();
        }
        
        

        private static float CalculateDiscount(float price)
        {
            return 0;
        }

        
    }
}
