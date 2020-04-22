using System;
using System.Collections.Generic;
using System.Text;

namespace Gradebook
{
    class Book
    {
        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;

        }

        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public void ShowStatistics()
        {
            var result = 0.0;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;

            foreach (var number in grades)
            {
                highGrade = Math.Max(number, highGrade);
                lowGrade = Math.Min(number, lowGrade);
                result += number;
            }
            result /= grades.Count;



            Console.WriteLine($"\nThe lowest Grade is: {lowGrade}");
            Console.WriteLine($"The average Result is {result:n1}");
            Console.WriteLine($"The highest Grade is: {highGrade}\n");


        }

        private List<double> grades;
        private string name;


    }
}
