using System;
using System.IO;

namespace homeWork6
{
    class Student
    {
        public string Name { get; set; }
        public int Cours { get; set; }
        public Student(int cours = 1, string name = "Empty_Name")
        {
            Name = name;
            Cours = cours;
        }

        public static void WriteHomework(string name)
        {
            File.WriteAllText($"Homework_is_{name}.txt", $"This homework students {name}");
        }
    }
}
