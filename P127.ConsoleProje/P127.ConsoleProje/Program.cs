using P127.ConsoleProje.Models;
using P127.ConsoleProje.Services;
using System;

namespace P127.ConsoleProje
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===================================");
            Console.WriteLine("Course Application");
            Console.WriteLine("===================================");
            int selection;

            do
            {
                Console.WriteLine("\n1.Qrup yarat.");
                Console.WriteLine("2.Telebe yarat.");
                Console.WriteLine("3.Butun qruplari goster");
                Console.WriteLine("4.Qrup adini deyis");
                Console.WriteLine("5.Butun telebeleri goster");
                Console.WriteLine("6.Qrup uzre telebeleri goster");
                Console.WriteLine("0. Cixis");
                string strSelection = Console.ReadLine();
                bool result = int.TryParse(strSelection, out selection);
                if (result)
                {
                    switch (selection)
                    {
                        case 1:
                            MenuServices.CreateGroupMenu();
                            break;
                        case 2:
                            MenuServices.CreatStudentMenu();
                            break;
                        case 3:
                            MenuServices.ShowAllgroupMenu();
                            break;
                        case 4:
                            MenuServices.EditGroupMenu();
                            break;
                        case 5:
                            MenuServices.ShowAllStudentMenu();
                            break;
                        case 6:
                            MenuServices.ShowStudentbyGroupNoMenu();
                            break;

                        default:
                            Console.WriteLine("Xos getdiniz");
                            break;
                    }
                }

            } while (selection != 0);
         
     
        }
    }
}
