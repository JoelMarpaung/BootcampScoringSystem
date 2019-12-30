using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Client.Models;

namespace Client.Utility
{
    public class DataStorage : Student
    {
        public static List<Student> GetAllStudents() => new List<Models.Student>
           {
               new Student { Name="Mike", Class="Turner", Score=35,},
                new Student { Name="Sonja", Class="Markus", Score=22,},
                new Student { Name="Luck", Class="Martins", Score=40},
                new Student { Name="Sofia", Class="Packner", Score=30},
                new Student { Name="John", Class="Doe", Score=45}


           };
    }
}
