using System;

class Program
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        string op = Console.ReadLine();

        if (op == "addition")
            Console.WriteLine(a + b);

        if (op == "subtraction")
            Console.WriteLine(a - b);

        if (op == "multiplication")
            Console.WriteLine(a * b);

        if (op == "division")
            Console.WriteLine(a / b);

        Console.ReadKey();
    }
}