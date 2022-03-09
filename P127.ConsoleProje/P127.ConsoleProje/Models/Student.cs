using P127.ConsoleProje.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace P127.ConsoleProje.Models
{
    class Student
    {
        public string Fullname;
        public string GroupNo;
        public StudentType Type;

        
        

        public Student(string fullname, string group, StudentType type)
        {
            Fullname = fullname;
            GroupNo = group;
            Type = type;
           
        }

    }
}
