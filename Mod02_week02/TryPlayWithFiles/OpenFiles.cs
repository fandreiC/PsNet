using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace TryPlayWithFiles
{
    public static  class OpenFiles
    {
        public static StringBuilder CreateText()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < 50; i++)
            {
                if (i % 5 == 0)
                { sb.AppendLine("This is incorect number " + i / 5); }
                else
                { sb.AppendLine(i.ToString()); }
            }
            return sb;
        }

        public static void CreateFile(string name)
        {
            bool isFile = File.Exists(name);

            if (!isFile)
            {
                using (StreamWriter sw = File.CreateText(name))
                {
                    
                }
            }
        }

        public static void WriteTextToFile(StringBuilder sbtext,string filepath)
        {
            string message = string.Empty;
            try
            {
                using (StreamWriter sw = File.AppendText(filepath))
                {
                    sw.WriteLine(sbtext);
                }
                message = "Ok";
            }
            catch (DirectoryNotFoundException ex)
            { message = ex.Message; }
            catch (Exception ex)
            { message = ex.Message; }
            finally
            { Console.WriteLine("Writing file ... "+ message); }
        }
        public static void WriteTextToFile<T>(List<T> listtext, string filepath)
        {
            if (typeof(T) == typeof(int))
            { Console.WriteLine("ints"); }
            if (typeof(T) == typeof(string))
            { Console.WriteLine("strings"); }

            string message = string.Empty;
            try
            {
                using (StreamWriter sw = File.AppendText(filepath))
                {
                    foreach (var line in listtext)
                    {
                        sw.WriteLine(line);
                    }
                }
                message = "Ok";
            }
            catch (DirectoryNotFoundException ex)
            { message = ex.Message; }
            catch (Exception ex)
            { message = ex.Message; }
            finally
            { Console.WriteLine("Writing file ... " + message); }
        }
        public static Numbers ReadFromFile(string filename)
        {
            List<int> correct = new List<int>();
            List<string> incorrect = new List<string>();
            string message= string.Empty;

            try
            {
                using (FileStream fs = File.OpenRead(filename))
                using (StreamReader sr = new StreamReader(fs))
                {
                    string line;
                    int correctLine;
                    while ((line = sr.ReadLine()) != null)
                    {
                        bool c = Int32.TryParse(line, out correctLine);
                        if (c)
                        { correct.Add(correctLine); }
                        else
                        { incorrect.Add(line.ToString()); }
                    }
                }
                message = "ok";
            }
            catch (DirectoryNotFoundException ex) { message = ex.Message; }
            catch (FileNotFoundException ex) { message = ex.Message; }
            catch (IOException ex) { message = ex.Message; }
            catch (Exception ex) { message = ex.Message; }
            finally {
                Console.WriteLine("Reading from file ... "+ message);
            }

            return new Numbers { correctNumbers = correct, incorrectNumbers = incorrect   };
        }
    }
}
