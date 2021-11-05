using System;
using System.Collections.Generic;

namespace homeWork6
{
    class Program
    {
        /*1) Make a Student class with a couple of self-taught name and course in which to study;
         * this class should contain the WriteHomework method, which will create a file on the computer Homework.txt with the content 
         * "This is the homework of a student." Imported this class must also be passed through the constructor.
         * 
         * 2) Write a Classroom class that contains a private List <Student> field. 
         * This class must have a WriteAllHomework method, which will call the WriteHomework method for each student list.
         * 3) Make a GetStudentsFromFile method in the Classroom class that will read students from a file and add them to
         * your List <Student>. The file format to be read must contain a record of one student on one line.
         * There can be as many such lines as you want.*/
        static void Main(string[] args)
        {
            Classroom classroom = new Classroom();
            classroom.WriteAllHomework(classroom.GetStudentsFromFile());
        }
    }
}
