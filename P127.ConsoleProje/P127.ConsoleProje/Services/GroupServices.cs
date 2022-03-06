using P127.ConsoleProje.Enum;
using P127.ConsoleProje.Interfaces;
using P127.ConsoleProje.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace P127.ConsoleProje.Services
{
    class GroupServices : IGroupInterface
    {
        private List<Group> _groups = new List<Group>();
        public List<Group> Groups => _groups;

        public string CreateGroup(string groupNo, Categories category, bool isonline)
        {
            throw new NotImplementedException();
        }

        public string CreateStudent()
        {
            throw new NotImplementedException();
        }

        public void EditGroup(string no, string newGroupno)
        {
            throw new NotImplementedException();
        }

        public void ShowAllGroup()
        {
            throw new NotImplementedException();
        }

        public void ShowAllStudents()
        {
            throw new NotImplementedException();
        }

        public void ShowStudentsInGroup(string groupno)
        {
            throw new NotImplementedException();
        }
    }
}
