using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //DONE-TODO: Print the Sum of numbers

            Console.WriteLine($"Sum: {numbers.Sum()}\n");

            //DONE-TODO: Print the Average of numbers

            Console.WriteLine($"Average: {numbers.Average()}\n");

            //DONE-TODO: Order numbers in ascending order and print to the console

            Console.WriteLine("Ascending Order:");
            var ascendingNumbers = numbers.OrderBy(x => x).ToArray();
            foreach (var number in ascendingNumbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();

            //DONE-TODO: Order numbers in descending order and print to the console

            Console.WriteLine("Descending Order:");
            var descendingNumbers = numbers.OrderByDescending(x => x).ToArray();
            foreach (var number in descendingNumbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();

            //DONE-TODO: Print to the console only the numbers greater than 6

            Console.WriteLine("Numbers > 6:");
            var numbersAboveSix = numbers.Where(x => x > 6).ToArray();
            foreach (var number in numbersAboveSix)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();

            //DONE-TODO: Order numbers in any order (ascending or desc) but only print 4 of them **foreach loop only!**

            Console.WriteLine("Print 4 #'s:");
            var onlyFour = numbers.OrderBy(x => x).Take(4).ToArray();
            foreach (var number in onlyFour)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();

            //DONE-TODO: Change the value at index 4 to your age, then print the numbers in descending order

            numbers[4] = 47; 
            Console.WriteLine("Descending Numbers Version 2:");
            var descNumbersTwo = numbers.OrderByDescending(x => x).ToArray();
            foreach (var number in descNumbersTwo)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();

            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

            //DONE-TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName.

            Console.WriteLine("Employees C & S:");
            var namesCAndS = employees.Where(x => x.FirstName.StartsWith('C') || x.FirstName.StartsWith('S'))
                .OrderBy(x => x.FirstName).ToList(); 
            namesCAndS.ForEach(x => Console.WriteLine(x.FullName));
            Console.WriteLine();
            
            //DONE-TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.

            Console.WriteLine("Employees over 26:");
            var namesTwentySixPlus = employees.Where(x => x.Age > 26).OrderBy(x => x.Age).ThenBy(x => x.FirstName).ToList();
            namesTwentySixPlus.ForEach(x => Console.WriteLine($"Name: {x.FullName}, Age: {x.Age}"));
            Console.WriteLine();
            
            //DONE-TODO: Print the Sum of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.

            Console.WriteLine("Employees Sum & Avg:");
            var sumYearsOfExperience = employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35).ToList();
            Console.WriteLine($"Total years of experience: {sumYearsOfExperience.Sum(x => x.YearsOfExperience)}");
            
            //DONE-TODO: Now print the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.

            var avgYearsOfExperience = employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35).ToList();
            Console.WriteLine($"Average years of experience: {avgYearsOfExperience.Average(x => x.YearsOfExperience)}");
            Console.WriteLine();

            //TODO: Add an employee to the end of the list without using employees.Add()

            employees = employees.Append(new Employee("Jane", "Smith", 35, 5)).ToList();

            foreach (var worker in employees)
            {
                Console.WriteLine($"Employee Name: {worker.FullName} | Age: {worker.Age} | YOE: {worker.YearsOfExperience}");
            }

            Console.WriteLine();

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
