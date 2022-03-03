using System;
using System.Collections.Generic;
using System.Text;

namespace P127.ConsoleProje.Models
{
    class Student
    {
        private string _fullname;
        Group GroupNo;
        public bool Type;
        
        public string FullName
        {
            get
            {
                return _fullname;
            }
            set
            {
                if (CheckFullName(value))
                {
                    _fullname = value;
                }
            }
        }
       



        public static bool CheckFullName(string fullname)
        {
            string[] strArr = fullname.Split();

            bool result = false;
            if (strArr.Length == 2)
            {
                foreach (string item in strArr)
                {
                    for (int i = 0; i < item.Length; i++)
                    {
                        if (char.IsLetter(item[i]) && char.IsUpper(item[0]))
                        {
                            result = true;
                        }
                        else
                        {
                            result = false;
                            break;
                        }
                    }
                    
                }
                return result;
            }
            return false;
        }

    }
}
