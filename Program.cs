using System;

public class NewBaseType
{
    static void Main(string[] args)
    {
        NewBaseType.RunProjectOne();
        Console.WriteLine("Pierwszy kod został uruchomiony.");

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
        NewBaseType.RunProjectTwo();
        Console.WriteLine("Drugi kod został uruchomiony.");
        Console.WriteLine("Ile masz lat?");

        if (int.TryParse(Console.ReadLine(), out int age))
        {
            if (age >= 0 && age <= 12)
            {
                Console.WriteLine("Jesteś Dzieckiem.");
            }
            else if (age >= 13 && age <= 19)
            {
                Console.WriteLine("Jesteś Nastolatkiem.");
            }
            else if (age >= 20 && age <= 64)
            {
                Console.WriteLine("Jesteś Dorosłym.");
            }
            else if (age >= 65)
            {
                Console.WriteLine("Jesteś Seniorem.");
            }
            else
            {
                Console.WriteLine("Nieprawidłowy wiek.");
            }
        }
        else
        {
            Console.WriteLine("Nieprawidłowy wiek.");
        }
    }
    internal static void RunProjectOne()
    {
    }

    internal static void RunProjectTwo()
    {
    }
}

