using System;

namespace _14._02._22_task_try_catch_olan_versiya
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("1-ci Ededi Daxil Edin");
                int number1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("2-ci Ededi Daxil Edin!");
                int number2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Operatoru Daxil Edin + (+,-,*,/)");
                string Operator = Convert.ToString(Console.ReadLine());
                switch (Operator)
                {
                    case "+":
                        Plus(number1, number2);
                        break;
                    case "-":
                        Minus(number1, number2);
                        break;
                    case "*":
                        Vurma(number1, number2);
                        break;
                    case "/":
                        Divide(number1, number2);
                        break;

                    default:
                        Console.WriteLine("Duzgun Operator Daxil Edin");
                        break;
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Cannot divide by zero. Please try again.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Xeta bas verdi biraz sonra tekrar edin");
            }
        }
        public static void Plus(int num1, int num2)
        {
            Console.WriteLine(num1 + num2);
        }
        public static void Minus(int num1, int num2)
        {
            Console.WriteLine(num1 - num2);
        }
        public static void Vurma(int num1, int num2)
        {

            Console.WriteLine(num1 * num2);
        }
        public static void Divide(int num1, int num2)
        {
            Console.WriteLine(num1 / num2);
        }
    }
}
