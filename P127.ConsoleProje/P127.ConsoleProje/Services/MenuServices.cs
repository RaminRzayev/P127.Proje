using P127.ConsoleProje.Enum;
using P127.ConsoleProje.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace P127.ConsoleProje.Services
{
    class MenuServices
    {
        public static GroupServices groupServices = new GroupServices();


        public static void CreateGroupMenu()
        {
            Console.WriteLine("Hansi bolme uzre tehsil alacaginizi secin:");
            foreach (Categories c in System.Enum.GetValues(typeof(Categories)))
            {
                Console.WriteLine($"{(int)c}. {c}");
            }
            int category;
            string catStr = Console.ReadLine();
            bool resultCat = int.TryParse(catStr, out category);
            bool isOnline = false;
            Console.WriteLine("Qrup Onlinedir? y");
            string isOnlineStr = Console.ReadLine();

            if (isOnlineStr.Trim().ToLower() == "y")
            {
                isOnline = true;
            }
            if (resultCat)
            {
                switch (category)
                {
                    case (int)Categories.Design:
                        string No = groupServices.CreateGroup(Categories.Design, isOnline);
                        Console.WriteLine($"{No} nomreli qrup yarandi");
                        break;
                    case (int)Categories.Programming:
                        No = groupServices.CreateGroup(Categories.Programming, isOnline);
                        Console.WriteLine($"{No} nomreli qrup yarandi");
                        break;
                    case (int)Categories.SystemAdministrator:
                        No = groupServices.CreateGroup(Categories.SystemAdministrator, isOnline);
                        Console.WriteLine($"{No} nomreli qrup yarandi");
                        break;
                    default:
                        Console.WriteLine("Zehmet olmasa duzgun nomre daxil edin");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Zehmet olmasa duzgun bolme daxil edin");
            }
        }
        public static void ShowAllgroupMenu()
        {

            groupServices.ShowAllGroup();
        }
        public static void EditGroupMenu()
        {
            Console.WriteLine("Zehmet olmasa Qrupu daxil edin:");
            string no = Console.ReadLine();
            Console.WriteLine("Zehmet olmasa yeni qrup adini dazil edesiniz:");
            string newNo = Console.ReadLine();
            groupServices.EditGroup(no, newNo);

        }
        public static void CreatStudentMenu()
        {
            Console.WriteLine("Ad ve Soyadi daxil edin:");
            string fullname = Console.ReadLine();
            Console.WriteLine("Daxil olacaginiz qrupun adini daxil edin:");
            string groupno = Console.ReadLine();
            if (groupServices.FindNo(groupno) == null)
            {
                Console.WriteLine($"{groupno} nomreli qrup mobcud deyil!");
                return;
            }

            Console.WriteLine("Siz hansi telebe novune aidsiniz?");
            foreach (StudentType c in System.Enum.GetValues(typeof(StudentType)))
            {
                Console.WriteLine($"{(int)c}. {c}");
            }
            int category;
            string catStr = Console.ReadLine();
            bool resultCat = int.TryParse(catStr, out category);
            if (resultCat)
            {
                switch (category)
                {
                    case (int)StudentType.Zemanetli:
                        groupServices.CreateStudent(groupno, fullname, StudentType.Zemanetli);
                        Console.WriteLine($"Adi ve Soyadi: {fullname}\nQrup nomresi:{groupno}\nTelebe novu:{StudentType.Zemanetli}");
                        break;
                    case (int)StudentType.Zemanetsiz:
                        groupServices.CreateStudent(groupno, fullname, StudentType.Zemanetsiz);
                        Console.WriteLine($"Adi ve Soyadi: {fullname}\nQrup nomresi:{groupno}\nTelebe novu:{StudentType.Zemanetsiz}");
                        break;

                    default:
                        Console.WriteLine("Zehmet olmasa duzgun reqem daxil edin");
                        break;
                }
            }
            
            else
            {
                Console.WriteLine("Zehmet olmasa Telebe novu secin.");
            }
            StudentType type = (StudentType)category;
            groupServices.CreateStudent(groupno, fullname,type );
        }
        public static void ShowStudentbyGroupNoMenu()
        {
            Console.WriteLine("Qrup nomresini daxil edin:");
            string groupNo = Console.ReadLine();
            if (groupServices.ShowStudentsInGroup(groupNo)==null)
            {
                Console.WriteLine($"{groupNo}-adli qrup movcud deyil");
                return;
            }
            foreach (var item in groupServices.ShowStudentsInGroup(groupNo))
            {
                Console.WriteLine($"Adi ve Soyadi: {item.Fullname}\nQrup nomresi: {item.GroupNo}\nTipi: {item.Type}");
            }
        }
        public static void ShowAllStudentMenu()
        {
            foreach (var item in groupServices.ShowAllStudents())
            {
                Console.WriteLine($"Adi ve Soyadi: {item.Fullname}\nQrup nomresi: {item.GroupNo}\nTipi: {item.Type}");
            }
        }

    }
}
