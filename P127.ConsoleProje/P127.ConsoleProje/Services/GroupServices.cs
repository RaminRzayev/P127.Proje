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



        public string CreateGroup( Categories category, bool isonline)
        {
            Group group = new Group( category, isonline);
            foreach (var item in _groups)
            {
                if (item.No==group.No)
                {
                    Console.WriteLine($"{item.No}-nomreli Qrup hal hazirda movcuddur");
                }
            }
            Groups.Add(group);
            return group.No;
        }

        public void CreateStudent(string no, string fullname, StudentType stdTyp)
        {
            Group group = FindNo(no);
            if (group== null)
            {
                Console.WriteLine($"{no}-adli qrup yoxdur");
                return;
            }
            if (group.Students.Length>=group.Limit)
            {
                Console.WriteLine($"{no}-adli qrup tam doludur");
                return;
            }
            Student student = new Student(no, fullname, stdTyp);
            group.AddStudent(student);
        }

        public void EditGroup(string no, string newGroupno)
        {
            Group group = FindNo(no);
            if (group==null)
            {
                Console.WriteLine($"{group.No} nomreli qrup movcud deyil!");
                return;
            }
            foreach (Group groupp in Groups)
            {
                if (groupp.No.ToLower().Trim()==newGroupno.ToLower().Trim())
                {
                    Console.WriteLine($"{newGroupno}-nomreli qrup artiq var");
                    return;
                }
            }
            group.No = newGroupno.ToUpper();
            Console.WriteLine($"{no} adli qrup ugurla yeni adina:{newGroupno} deyistirildi");
        }

        public void ShowAllGroup()
        {
            if (_groups.Count == 0)
            {
                Console.WriteLine("Umumiyyetle Qrup yoxdur");
                return;
            }
            foreach (Group group in Groups)
            {
                Console.WriteLine($"No: {group.No} - Nov: {group.Category}- Online? :{group.IsOnline} - Limit: {group.Limit} -  Telebe sayi: {group.Students.Length}");
            }
        }

        public Student[] ShowAllStudents()
        {
            Student[] students = new Student[0];
            foreach (var group in _groups)
            {
                foreach (var student in group.Students)
                {
                    Array.Resize(ref students, students.Length + 1);
                    students[students.Length - 1] = student;
                }
            }
            return students;
        }

        public Student[] ShowStudentsInGroup(string groupno)
        {
            Group group = FindNo(groupno);
            if (group==null)
            {
                Console.WriteLine($"{group} nomreli qrup movcud deyil!");
                return null;
            }
            return group.Students;
        }



        public Group FindNo(string no)
        {
            foreach (var item in _groups)
            {
                if (item.No == no)
                {
                    return item;
                }
            }
            return null;
        }

    }
}
