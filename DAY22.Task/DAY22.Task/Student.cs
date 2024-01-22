using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace DAY22.Task
{
    internal class Student
    {
        private string _fullname;
        private string _groupNO;
        public byte Age;
        public string Fullname
        {
            get => _fullname;
            set
            {
                if (CheckFullname(value))
                {
                    _fullname = value;
                }
            }
        }

        public string GroupNo
        {
            get => _groupNO;
            set
            {
                if(CheckGroupNo(value))
                {
                    _groupNO = value;
                }
            }
        }


        public static bool CheckFullname(string fullname)
        {
            if (string.IsNullOrWhiteSpace(fullname)) return false;

            string[] parts = fullname.Split(' ');

            if (parts.Length != 2) return false;

           for (int i = 0;i < parts.Length; i++)
            {
                if (!IsLettersOnly(parts[i])) return false;
            }
            return true;

           
        }


        public static bool CheckGroupNo(string groupno)
        {
            if (string.IsNullOrWhiteSpace(groupno) || groupno.Length < 4)
            {
                return false;
            }

            string letterPart = groupno.Substring(0, 1);
            string numberPart = groupno.Substring(1);

            if (IsLetter(letterPart) && IsDigit(numberPart))
            {
                return true;
            }

            return false;
        }


        #region Additional methods
        protected static bool IsLettersOnly(string str)
        {
            if (string.IsNullOrWhiteSpace(str)) return false;

            for (int i = 0; i < str.Length; i++)
            {
                if (!char.IsLetter(str[i])) return false;
            }

            return true;
        }

        private static bool IsLetter(string str)
        {
            return !string.IsNullOrEmpty(str) && str.Length == 1 && char.IsUpper(str[0]);
        }

        private static bool IsDigit(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (!char.IsDigit(str[i]))
                {
                    return false;
                }
            }
            return true;
        }

        public static string CapitalizeFullname(string fullname)
        {
            string[] parts = fullname.Split(' ');

            for (int i = 0; i < parts.Length; i++)
            {
                parts[i] = char.ToUpper(parts[i][0]) + parts[i].Substring(1).ToLower();
            }

            return string.Join(" ", parts);
        }

        #endregion

    }
}
