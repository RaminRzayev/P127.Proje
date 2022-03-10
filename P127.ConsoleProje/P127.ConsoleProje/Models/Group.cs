using P127.ConsoleProje.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace P127.ConsoleProje.Models
{
    class Group
    {
        public static int count = 0;
        public string No;
        public Categories Category;
        public bool IsOnline;
        public byte Limit;
        public Student[] Students;


        public Group( Categories categories, bool isonline)
        {
            Students = new Student[0];
            IsOnline = isonline;
            switch (categories)
            {
                case Categories.Programming:
                    No = $"P{100 + count}";
                    break;
                case Categories.Design:
                    No = $"D{200 + count}";
                    break;
                case Categories.SystemAdministrator:
                    No = $"S{300 + count}";
                    break;
                default:
                    break;
            }
            count++;
            if (isonline)
            {
                Limit = 15;
            }
            else
            {
                Limit = 10;
            }
        }


       
        public void AddStudent(Student student)
        {

                Array.Resize(ref Students, Students.Length + 1);
                Students[Students.Length - 1] = student;
       
        }
        public override string ToString()
        {
            return $"No: {No}, Online: {IsOnline}";
        }

    }
}
