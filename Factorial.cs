using System;

class Factorial
{
   public void Factor()
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        
        int fact = 1;
        for (int i = 1; i <= num; i++)
        {
            fact *= i;
        }
        
        Console.WriteLine("Factorial of " + num + " = " + fact);
    }
}
