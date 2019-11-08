using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                while (flag)
                {
                    Console.WriteLine("Enter numbers for operation:");
                    Console.Write("Enter number a: ");
                    if (!(double.TryParse(Console.ReadLine(), out double a)))
                    {
                        Console.WriteLine("Invalid value! (Press any button to conitue)");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }
                    Console.Write("Enter number b: ");
                    if (!(double.TryParse(Console.ReadLine(), out double b)))
                    {
                        Console.WriteLine("Invalid value! (Press any button to conitue)");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }
                    Console.WriteLine("Choose operation type (addition - \"ADD\", subtraction - \"SUB\", multiplication - \"MUL\" or division - \"DIV\"):");
                    string operation = Console.ReadLine();
                    switch (operation.ToLower())
                    {
                        case "add":
                            Console.WriteLine($"The Result is: a+b= {a + b}");
                            break;
                        case "sub":
                            Console.WriteLine($"The result is: a-b= {a - b}");
                            break;
                        case "mul":
                            Console.WriteLine($"The result is: a*b= {a * b}");
                            break;
                        case "div":
                            Console.WriteLine($"The result is: a/b= {a / b}");
                            break;
                        default:
                            Console.WriteLine("Invalid operation type!");
                            break;
                    }
                    Console.WriteLine("Press ESC to exit or any other button to repeat");
                    if (Console.ReadKey().Key == ConsoleKey.Escape)
                    {
                        flag = false;
                    }
                    else
                    {
                        Console.Clear();
                    }
                }
            }
        }
    }
}
