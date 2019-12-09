using System;
using System.Linq;

namespace Age_Processing
{
    class Program
    {
        private enum genderTypes { M, F }
        private static int month, year, day;
        private static genderTypes? gender;
        private static DateTime birthDay;
        static void Main(string[] args)
        {
            ReadDataForAge();
            bool is_validDate = TransformDataForAge();
            int age;
            if (is_validDate)
            {
                age = CalculateAge();

                if (gender != null)
                {
                    if (gender == genderTypes.M)
                        if (age > 65)
                            Console.WriteLine("You are retired! (Male)");
                        else Console.WriteLine($"you need {65-age} more years to retire");
                    else
                        if (age > 63)
                        Console.WriteLine("You are retired! (Female)");
                        else Console.WriteLine($"you need {63 - age} more years to retire");
                }
            }
            Console.ReadKey();
        }
        private static int CalculateAge()
        {
            int age = DateTime.Today.Year - birthDay.Year;
            Console.WriteLine("Your age is : " + age);
            return age;
        }
        private static bool TransformDataForAge()
        {
            string birthdayValue = year + "-" + month + "-" + day;
            if (!DateTime.TryParse(birthdayValue, out birthDay))
            {
                Console.WriteLine("error reading date ! Program will end ");
                return false;
            }
            return true;
        }

        private static void ReadDataForAge()
        {
            Console.WriteLine(" Insert your birthday, please!");

            string genderValue;
            bool checkValues;
            do
            {
                checkValues = true;
                Console.WriteLine("Insert year >> ");
                Int32.TryParse(Console.ReadLine(), out year);
                Console.WriteLine("Insert month >> ");
                Int32.TryParse(Console.ReadLine(), out month);
                Console.WriteLine("Insert day >> ");
                Int32.TryParse(Console.ReadLine(), out day);
                Console.WriteLine("Insert Gender (M-Male/F-Female) : (M/F) >> ");
                //Enum.TryParse<genderTypes>( Console.ReadLine(),out gender);
                genderValue = Console.ReadLine().ToUpper();
                if (year < 1000 || year > DateTime.Today.Year || month < 1 || month > 12 || day < 1 || day > 31)
                {
                    checkValues = false;
                    Console.WriteLine("You inserted invalid data! Retry:");
                }
                bool genderCheck = Enum.GetNames(typeof(genderTypes)).Contains(genderValue);
                if (!genderCheck)
                    gender = null;
                else
                    gender = genderValue == genderTypes.M.ToString() ? genderTypes.M : genderTypes.F; 


            } while (!checkValues);
        }
    }
}
