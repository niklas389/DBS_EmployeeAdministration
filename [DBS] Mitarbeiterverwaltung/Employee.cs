using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _DBS__Mitarbeiterverwaltung
{
    public enum sex { male, female, other}
    public class Employee
    {
        public string Name;
        public decimal Salary;
        public sex Sex;
        public bool CovidSalary;
    }
}
