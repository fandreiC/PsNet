using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TryPlayWithFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            DoWork();

            Console.ReadKey();
        }

        public static void DoWork()
        {
            StringBuilder sb = new StringBuilder();
            sb = OpenFiles.CreateText();
                        
            string filename = "numbers.txt";
            string destPath0 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, filename);
            OpenFiles.CreateFile(filename);

            OpenFiles.WriteTextToFile(sb,filename);

            Numbers numberLists = new Numbers();
            numberLists = OpenFiles.ReadFromFile(filename);

            string correctNumbersFile = "correctNumbers.txt", incorrectNumbersFile = "incorrectNumbersFile.txt";
            string destPath1 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, correctNumbersFile);
            string destPath2 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, incorrectNumbersFile);

            OpenFiles.WriteTextToFile(numberLists.correctNumbers, destPath1);
            OpenFiles.WriteTextToFile(numberLists.incorrectNumbers, destPath2);


        }
    }
}
