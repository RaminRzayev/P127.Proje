using P127.ConsoleProje.Models;
using P127.ConsoleProje.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace P127.ConsoleProje.Interfaces
{
    interface IGroupInterface
    {
        public List<Group> Groups { get; }


        public string CreateGroup(string groupNo, Categories category, bool isonline);
        public void ShowAllGroup();
        public void EditGroup(string no, string newGroupno);
        public void ShowStudentsInGroup(string groupno);
        public void ShowAllStudents();
        public string CreateStudent();
    }
}
