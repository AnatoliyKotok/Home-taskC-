using System;

namespace Pract_task_new
{
    class Program
    {
        private static void Task6()
        {
            Console.WriteLine("input name profesion");
            string name = Console.ReadLine();
            Console.WriteLine("input time");
            int time = Convert.ToInt32(Console.ReadLine());
            switch (name)
            {
                case "Developer":
                    int inhour = 20;
                    int salary = time * inhour;
                    Console.WriteLine($"{name} salary for {time} is {salary} $");
                    break;
                case "Manager":
                    int inhour2 = 15;
                    int salary2 = time * inhour2;
                    Console.WriteLine($"{name} salary for {time} is {salary2} $");
                    break;
            }
        }

        private static void Task4()
        {
            Console.WriteLine("Input two numbers");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            if (a < 0 || a > b)
            {
                Console.WriteLine("Incorect numbers");
            }
            else
            {
                while (a <= b)
                {
                    for (int i = 1; i <= a; i++)
                        Console.Write("{0}", a);
                    a++;
                    Console.WriteLine();
                }
                Console.ReadKey();
            }
        }

        private static char Task3()
        {
            char a;
            while ((a = (char)Console.Read()) != '.')
            {
                if (char.IsLower(a))
                {
                    Console.Write(char.ToUpper(a));
                }
                if (char.IsUpper(a))
                {
                    Console.Write(char.ToLower(a));
                }



            }

            return a;
        }

        private static void Task1()
        {
            char symbol;
            int count = 0;
            do
            {
                symbol = Convert.ToChar(Console.Read());
                if (char.IsWhiteSpace(symbol))
                {
                    ++count;

                }
            } while (symbol != '.');
            Console.WriteLine($"you entered point\ncount of space->{count}");
            return;
        }
        private static void Task2()
        {
            Console.WriteLine("Input number->");

            string number = Console.ReadLine();
            int sum1 = 0;
            int sum2 = 0;
            if (number.Length > 6 || number.Length < 6)
            {
                Console.WriteLine("Incorct number");

            }
            else
            {
                for (int i = 0; i < 2; i++)
                {
                    sum1 += (number[i] - 48);
                }
                for (int j = 3; j < 5; j++)
                {
                    sum2 += (number[j] - 48);
                }
                Console.WriteLine($"First part->{sum1}");
                Console.WriteLine($"Second part->{sum2}");
                if (sum1 == sum2)
                {
                    Console.WriteLine("Happy ticket");
                }
                else
                {
                    Console.WriteLine("Unhappy ticket");
                }
            }
        }
        private static void Task5()
        {
            int res = 0;
            int n = 451;
            while (n > 0)
            {
                res *= 10;
                res += n % 10;
                n /= 10;
            }
            Console.WriteLine(res);
        }
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
            Task4();
            Task5();
            Task6();
        }
    }
}
