using System;
using System.Text;

namespace StringPlay
{
    class StringPlayManager
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Strings!");

            string longText = "    @This @is @a @phrase @with @spaces!    ";
            longText= longText.Trim();
            string[] words = longText.Split(' ');
            string[] wordsNew = new string[words.Length];
            int x = 0;
            foreach (var word in words)
            {                
                if (word.Contains("@"))
                   wordsNew[x++]=word.Remove(0,1);
            }
            string space = "spaces!";
            string peace;
            if (wordsNew[5].ToLower().Equals(space.ToLower()))
                peace=space.Replace("s","");
            if (longText.StartsWith("@"))
                longText=longText.Replace("@", "#");
            string url = "c:\\Local\\User\\file.cs";

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 10; i++)
            {
                sb.Append(" New year 200" + i);
                if (i == 4)
                    sb.AppendLine();
            }
            sb.Replace("00","99");


            Console.ReadKey();
        }
    }
}
