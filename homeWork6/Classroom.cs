using System.Collections.Generic;
using System.IO;

namespace homeWork6
{
    class Classroom
    {
        private List<Student> studentsHomeworks = new List<Student>();
        public List<Student> StudentsHomeworks
        {
            get => studentsHomeworks;
            set => studentsHomeworks = value;
        }

        public void WriteAllHomework(List<string> ListWithStudentsName)
        {
            foreach (string name in ListWithStudentsName)
            {
                Student.WriteHomework(name);
            }
        }

        public List<string> GetStudentsFromFile()
        {
            List<string> ListWithStudentsName = new List<string>();
            string[] ArrayWithStudentsName = File.ReadAllLines(@"C:\Users\Yurii Shymko\source\Repos\Courses\homeWork6\Students.txt");
            Student[] students = new Student[ArrayWithStudentsName.Length];
            for (int i = 0; i < ArrayWithStudentsName.Length - 1; i++)
            {
                ListWithStudentsName.Add(ArrayWithStudentsName[i].Remove(ArrayWithStudentsName[i].Length - 2));
                students[i] = new Student(int.Parse(ArrayWithStudentsName[i].Remove(0, ArrayWithStudentsName[i].Length - 1)), ListWithStudentsName[i]);
                StudentsHomeworks.Add(students[i]);
            }
            return ListWithStudentsName;
        }
    }
}