using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string surname = "";
            string gender = "";
            DateTime birth = new DateTime (2005,07,16);
            string ResidentOfRomania = "Да";
            string City = "Алба";

            string Id = "12";

            // 1 цифра
            if (ResidentOfRomania == "Да")
            {
                if (birth.Year >= 1900 && birth.Year <= 1949)
                {
                    Id = "1";
                }
                if (birth.Year >= 1950 && birth.Year <= 1999)
                {
                    Id = "2";
                }
                if (birth.Year >= 1800 && birth.Year <= 1849)
                {
                    Id = "3";

                }
                if (birth.Year >= 1850 && birth.Year <= 1899)
                {
                    Id = "4";
                }
                if (birth.Year >= 2000 && birth.Year <= 2049)
                {
                    Id = "5";
                }
                if (birth.Year >= 2050 && birth.Year <= 2099)
                {
                    Id = "6";
                }
            }
            else
            {
                Random rnd = new Random();
                Id =Convert.ToString( rnd.Next(7, 9));
            }
            
            //2,3 цифра
            string a = birth.Year.ToString();
            
                Id += $"{Char.GetNumericValue(Convert.ToString( birth.Year)[2])}{Char.GetNumericValue(Convert.ToString(birth.Year)[3])}";


            // 4,5 цифры
            if (birth.Month < 10)
            {
                Id += $"0{birth.Month}";
            }
            else
            {
                Id += $"{Char.GetNumericValue(Convert.ToString(birth.Month)[0])}{Char.GetNumericValue(Convert.ToString(birth.Month)[1])}";
            }

            //6,7 цифры
            if (birth.Day < 10)
            {
                Id += $"0{birth.Day}";
            }
            else
            {
                Id += $"{Char.GetNumericValue(Convert.ToString(birth.Day)[0])}{Char.GetNumericValue(Convert.ToString(birth.Day)[1])}";
            }

            //8,9 цифры
            if (City== "Алба"|| City == "Алба-Юлия" || City == "AB")
            {
                Id += 1;
            }
            if (City == "Арджеш " || City == "Питешти" || City == "AG")
            {
                Id += 1;
            }
            if (City == "Арад " || City == "AR")
            {
                Id += 1;
            }
            if (City == "Бухарест" || City == "B")
            {
                Id += 1;
            }
            if (City == "Бакэу "|| City == "BC")
            {
                Id += 1;
            }
            if (City == "Бихор " || City == "Орадя" || City == "BH")
            {
                Id += 1;
            }
            if (City == "Бистрица-Нэсэуд" || City == "Бистрица" || City == "BN")
            {
                Id += 1;
            }
            if (City == "Брэила" || City == "BR")
            {
                Id += 1;
            }
            if (City == "Алба" || City == "Алба-Юлия" || City == "AB ")
            {
                Id += 1;
            }
            if (City == "Алба" || City == "Алба-Юлия" || City == "AB ")
            {
                Id += 1;
            }
            if (City == "Алба" || City == "Алба-Юлия" || City == "AB ")
            {
                Id += 1;
            }
            if (City == "Алба" || City == "Алба-Юлия" || City == "AB ")
            {
                Id += 1;
            }

            Console.WriteLine(Id);
        }
        
}
}
