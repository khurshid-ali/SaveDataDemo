using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaveDataDemo;

public class FileManager
{
    public FileManager(string filePath)
    {
        this.FilePath = filePath;

    }
    public string FilePath { get; }


    public List<Student> LoadFile()
    {
        var studentList = new List<Student>();

        if (File.Exists(FilePath))
        {
            using (StreamReader reader = File.OpenText(FilePath))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine().Split(",");
                    var student = new Student(line.First(), DateTime.Parse(line.Last()));
                    studentList.Add(student);

                }
            }
        }

        return studentList;
    }

    public void SaveToFile(List<Student> studentList)
    {
        using (StreamWriter writer = File.CreateText(FilePath))
        {
            foreach (var student in studentList)
            {
                writer.WriteLine("{0},{1}", student.Name, student.DateOfBirth.ToString());
            }
        }
    }


}
