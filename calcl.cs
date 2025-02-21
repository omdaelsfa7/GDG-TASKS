using System;
using System.Globalization;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        double num1, num2, res;
        char op, checker;

        bool flag = true;
        while (flag)
        {
            Console.WriteLine("Enter the First Number");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the operator");
            op = Console.ReadLine()[0];

            Console.WriteLine("Enter the Second Number");
            num2 = Convert.ToDouble(Console.ReadLine());

            switch (op)
            {
                case '+':
                    res = num1 + num2;
                    Console.WriteLine("the sum = " + res);
                    break;
                case '-':
                    res = num1 - num2;
                    Console.WriteLine("the subtraction = " + res);
                    break;
                case '/':
                    if (num2 == 0)
                    {
                        Console.WriteLine("cant divide on 0 ");
                        break;

                    }
                    res = num1 / num2;
                    Console.WriteLine("the division = " + res);
                    break;
                case '*':
                    res = num1 * num2;
                    Console.WriteLine("the multiplcation = " + res);
                default:
                    Console.WriteLine("error");
                    break;
            }
            Console.WriteLine("Press x to exit or y to go again");
            checker = Console.ReadLine()[0];
            if (checker == 'x')
            {
                flag = false;
            }
        }

    }
}