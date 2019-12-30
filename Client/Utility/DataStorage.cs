using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Client.Models;

namespace Client.Utility
{
    public class DataStorage : Employee
    {
        public static List<Employee> GetAllEmployess() => new List<Models.Employee>
           {
               new Employee { Name="Mike", Class="Turner", Score=35,},
                new Employee { Name="Sonja", Class="Markus", Score=22,},
                new Employee { Name="Luck", Class="Martins", Score=40},
                new Employee { Name="Sofia", Class="Packner", Score=30},
                new Employee { Name="John", Class="Doe", Score=45}


           };
    }
}
