using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaveDataDemo;

public class Student
{
    public Student(string name, DateTime dateOfBirth)
    {
        this.Name = name;
        this.DateOfBirth = dateOfBirth;

    }
    public string Name { get; set; }

    public DateTime DateOfBirth { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine("{0}, {1}", Name, DateOfBirth.ToString("dd MMM, yyyy"));
    }


}
