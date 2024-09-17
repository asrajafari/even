using System;

class Even
{
    static void Main()

    {
        Console.WriteLine("Enter your choise");

        int choise = int.Parse(Console.ReadLine());

        for (int i = 0 ; i <= 100 ; i++)

            if (i % 2 == 0 )
            {
                Console.WriteLine(i+ "Even number");
            }
            else
            {
                Console.WriteLine(i+ "Odd number");
                Console.WriteLine("try again");
                Console.ReadLine();
            }
        {
            
        }
    }
    
}

