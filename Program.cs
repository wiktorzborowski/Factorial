using System;
					
public class Program
{
	public static void Main()
	{
        Console.WriteLine("Type a positive integer from 1 to 25: ");
        string inputString = Console.ReadLine();
        try
        {
            int inputValue = Convert.ToInt32(inputString);
            if (inputValue <= 0 || inputValue > 25)
            {
                Console.WriteLine("Wrong input " + inputString);
            }
            else
            {
                Console.WriteLine("Loop result factorial for " + inputValue + " is " + CalculateFactorialLoop(inputValue));
                Console.WriteLine("Recurrence result factorial for " + inputValue + " is " + CalculateFactorialRecurrence(inputValue));
            }
        }
        catch
        {
            Console.WriteLine("Wrong input " + inputString);
        } 
	}
    private static long CalculateFactorialLoop(int a)
    {
        long result = 1;
        for (int i = 1; i <= a; i++)
        {
            result = result * i;
        }
        return result;
    }
    private static long CalculateFactorialRecurrence(long a)
    {
        if (a == 0 || a == 1)
        {
            return 1;
        }
        else
        {
            return a * CalculateFactorialRecurrence(a - 1);
        }
    }
}