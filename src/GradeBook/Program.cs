using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;

namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {            
            var book = new Book("Nico's Grade Book");
            book.AddGrade(89.3);
            book.AddGrade(87.09);
            book.AddGrade(41.7);
            book.ShowStatistics();

           Console.ReadLine();
            
            
        }
    }
}