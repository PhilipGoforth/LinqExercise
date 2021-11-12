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
             *
             * HINT: Use the List of Methods defined in the Lecture Material Google Doc ***********
             *
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //Print the Sum and Average of numbers
            Console.WriteLine(numbers.Sum());
            Console.WriteLine("--------");
            Console.WriteLine(numbers.Average());
            Console.WriteLine("--------");

            //Order numbers in ascending order and decsending order. Print each to console.
            var orderNum = numbers.OrderBy(x => x).ToArray();
            orderNum.ToList().ForEach(x => Console.WriteLine(x));
            Console.WriteLine("--------");
            orderNum.OrderByDescending(x => x).ToList().ForEach(x => Console.WriteLine(x));
            Console.WriteLine("--------");
            //Print to the console only the numbers greater than 6
            var aboveSix = orderNum.Where(x => x > 6);
            aboveSix.ToList().ForEach(x => Console.WriteLine(x));
            Console.WriteLine("--------");
            //Order numbers in any order (acsending or desc) but only print 4 of them **foreach loop only!**
            var onlyFour = numbers.OrderByDescending(x => x).Take(4).ToList();
            onlyFour.ToList().ForEach(x => Console.WriteLine(x));
            Console.WriteLine("--------");
            //Change the value at index 4 to your age, then print the numbers in decsending order
            numbers[4] = 32;
            numbers.ToList().OrderByDescending(x => x).ToList().ForEach(x => Console.WriteLine(x));
            Console.WriteLine("--------");
            // List of employees ***Do not remove this***
            var employees = CreateEmployees();

            //Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S.
            //Order this in acesnding order by FirstName.
            var newList = employees.Where(x => x.FirstName[0] == 'C' || x.FirstName[0] == 'S');
            newList.ToList().OrderBy(x => x.FirstName).ToList().ForEach(x => Console.WriteLine(x.FullName));

            Console.WriteLine("--------");
            //Print all the employees' FullName and Age who are over the age 26 to the console.
            var ageList = employees.Where(x => x.Age > 26);
            ageList.ToList().OrderBy(x => x.Age).ToList().ForEach(x => Console.WriteLine($"{x.FullName} {x.Age}"));
            Console.WriteLine("--------");
            ageList.ToList().OrderBy(x => x.FirstName).ToList().ForEach(x => Console.WriteLine($"{x.FullName} {x.Age}"));
            Console.WriteLine("--------");
            //Order this by Age first and then by FirstName in the same result.

            //Print the Sum and then the Average of the employees' YearsOfExperience
            //if their YOE is less than or equal to 10 AND Age is greater than 35
            var expList = employees.Where(x => x.YearsOfExperience <= 10 && x.YearsOfExperience > 35);
            var expArr = employees.Select(x => x.YearsOfExperience).ToArray();
            Console.WriteLine(expArr.Sum());
            Console.WriteLine("--------");
            Console.WriteLine(expArr.Average());
            Console.WriteLine("--------");

            //Add an employee to the end of the list without using employees.Add()
            
            employees.Append(new Employee("Philip", "Goforth", 32, 5));

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
