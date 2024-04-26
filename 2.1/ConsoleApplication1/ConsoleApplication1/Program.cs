using System;

class Program
{
    static void Main()
    {
        string J = Console.ReadLine(); 
        string S = Console.ReadLine(); 

        int count = 0; 

        foreach (char jewel in J)
        {
            foreach (char stone in S)
            {
                if (jewel == stone)
                {
                    count++; 
                }
            }
        }

        Console.WriteLine(count); 
    }
}