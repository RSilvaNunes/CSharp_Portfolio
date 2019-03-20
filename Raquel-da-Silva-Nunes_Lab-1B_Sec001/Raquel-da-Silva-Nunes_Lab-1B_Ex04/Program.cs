using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raquel_da_Silva_Nunes_Lab_1B_Ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Generic SortedDictionary data structure
            SortedDictionary<int, Employee> list = new SortedDictionary<int, Employee>();

            Employee emp1 = new Employee("John", 10000.1);
            Employee emp2 = new Employee("Paul", 20000.2);
            Employee emp3 = new Employee("Raquel",30000.3);
            Employee emp4 = new Employee("Karen", 40000.5);
            Employee emp5 = new Employee("Claire", 22000.6);

            list.Add(1, emp1);
            list.Add(2, emp2);
            list.Add(3, emp3);
            list.Add(4, emp4);
            list.Add(5, emp5);

            // item (a) Add an employee to the dictionary
            Employee emp6 = new Employee("Terry", 15000.9);
            AddDictionaryItem(list, emp6);

            // item (b) Remove an employee from the list
            RemoveDictionaryItem(list, 5);

            // item (c) Display the items of SortedDictionary
            PrintDictionary(list);

            // item (d) Search an employee
            SearchDictionaryItem(list, 3);
            SearchDictionaryItem(list, 77);

            // item (e) Find an employee with the highest salary
            MaxDictionaryItem(list);
        }
        //item (a) Define a method to add an employee to the dictionary
        public static void AddDictionaryItem(SortedDictionary<int, Employee> list, Employee emp)
        {
            var size = list.Count;
            list.Add(list.Keys.Max() + 1, emp);
        }
        // item (b) Define a method to remove a employee from the list
        public static void RemoveDictionaryItem(SortedDictionary<int, Employee> list, int key)
        {
            list.Remove(key);
        }
        // item (c) Define a method to display the items of SortedDictionary
        public static void PrintDictionary(SortedDictionary<int, Employee> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine($"{item}");
            }
        }
        // item (d) Define a method to search an employee
        public static void SearchDictionaryItem(SortedDictionary<int, Employee> list, int key)
        {
            foreach (var item in list)
            {
                if (item.Key == key)
                {
                    Console.WriteLine($"Found record - {item.Value}");
                    return;
                }
            }

            Console.WriteLine("Not found!");
        }
        // item (e) Define a method to find an employee with the highest salary
        public static void MaxDictionaryItem(SortedDictionary<int, Employee> list)
        {
            double maxSalary = 0.0;
            Employee employee = null;
            foreach (var item in list)
            {
                if (item.Value.Salary > maxSalary)
                {
                    employee = item.Value;
                    maxSalary = item.Value.Salary;
                }
            }

            Console.WriteLine($"The highest salary is {employee.Salary} from {employee.Name}");
        }
    }
}
