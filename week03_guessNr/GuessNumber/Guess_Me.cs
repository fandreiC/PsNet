    using System;

    namespace GuessNumber
    {
        class Program
        {
            private static int luckyNumber;
            static void Main(string[] args)
            {
                LuckyNumberMet();

                Console.ReadKey();
            }

            private static void LuckyNumberMet()
            {
                Console.WriteLine("Guess the number ! Press 0(ZERO) to EXIT! ");
                Console.WriteLine("Guess a number beteen 1-100 !");
                int nr = 1;
                Random rnd = new Random();
                luckyNumber = rnd.Next(100);

                while (nr != 0)
                {
                    Console.WriteLine("Insert number! >> ");
                    Int32.TryParse(Console.ReadLine(), out nr);
                    if (nr == 0)
                    {
                        Console.WriteLine("You exited program ! Good BYE !");
                        break;
                    }
                    if (!(nr > 0 && nr < 101))
                    {
                        Console.WriteLine("Number not in range :  0-100 !  Insert another one: ");
                        continue;
                    }
                    nr = GuessNumber(nr);
                }
            }

            private static int GuessNumber(int nr)
            {
                if (nr == luckyNumber)
                {
                    Console.WriteLine($" You were right ! Well Done! Number {nr} is the Lucky Number!");
                    return 0;
                }
                if (nr < luckyNumber)
                {
                    Console.WriteLine("The number you inserted was too SMALL");
                }
                if (nr > luckyNumber)
                {
                    Console.WriteLine("The number you inserted was too BIG");
                }
                return nr;
            }

        }
    }
