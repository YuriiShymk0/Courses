using System;
using System.Collections.Generic;

namespace homeWork6
{
    class Program
    {
        static void Main(string[] args)
        {
            Classroom classroom = new Classroom();
            classroom.WriteAllHomework(classroom.GetStudentsFromFile());
        }
    }
}
