using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raquel_da_Silva_Nunes_Lab_1B_Ex04
{
    class Employee
    {
        //Auto-implemented properties
        public string Name { get; set; }
        public double Salary { get; set; }

        //Constructor
        public Employee(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }
        //Override ToString method
        public override string ToString()
        {
            return $"{Name},{Salary}";
        }
    }
}
