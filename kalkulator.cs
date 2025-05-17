using System;

class Kalkulator
{
    static void Main()
    {
        Console.Write("Podaj pierwszą liczbę: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Podaj drugą liczbę: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Wybierz działanie (+ - * /): ");
        string op = Console.ReadLine();

        double wynik = 0;
        switch (op)
        {
            case "+": wynik = a + b; break;
            case "-": wynik = a - b; break;
            case "*": wynik = a * b; break;
            case "/": wynik = b != 0 ? a / b : 0; break;
            default: Console.WriteLine("Nieznane działanie."); return;
        }

        Console.WriteLine("Wynik: " + wynik);
    }
}
