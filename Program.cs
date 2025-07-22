using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Swap ss = new Swap();
        ss.Swapping();
        Multiplication mm = new Multiplication();
        mm.Multi();
        ArithmeticOperations ac = new ArithmeticOperations();
        ac.Arithmetic();
        Result rr = new Result();
        rr.Resulting();
    }
}

