using System;

class Program
{  
    static int MultiplyValues(int value, int count = 2)
    {
        int total = 0;
        for (int k = 0; k < count; k++)
        {
            total += value;
        }
        return total;
    }

    static double MultiplyValues(double value, int count = 2)
    {
        double total = 0;
        for (int k = 0; k < count; k++)
        {
            total += value;
        }
        return total;
    }

    static string MultiplyValues(string value, int count = 2)
    {
        string combined = string.Empty;
        for (int k = 0; k < count; k++)
        {
            combined += value;
        }
        return combined;
    }

    static void Main(string[] args)
    {    
        // int 
        Console.WriteLine(MultiplyValues(10, 5));
        Console.WriteLine(MultiplyValues(3));
        Console.WriteLine();
        
        // double
        Console.WriteLine(MultiplyValues(5.5, 10));
        Console.WriteLine(MultiplyValues(2.5));
        Console.WriteLine();
        
        // String 
        Console.WriteLine(MultiplyValues("hello ", 10));
        Console.WriteLine(MultiplyValues("hello "));
        Console.WriteLine();
    }
}
