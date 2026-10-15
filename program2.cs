using System;
 
  class Program2
    {
        static void Main()
        {
         Console.WriteLine("Podaj liczbę!");
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            if (number % 2 == 0)
            {
                Console.WriteLine("Liczba jest parzysta.");
            }
            else
            {
                Console.WriteLine("Liczba jest nieparzysta.");
            }
        }
        else
        {
            Console.WriteLine("Nieprawidłowa liczba.");
        }
        }
    }
