using System;

public class Program
{
    public static void Main()
    {
        string[] slowa = { "pies", "kot", "auto", "dom" };
        string[] smierc = {
            "Smierc...", "Smierc czai sie...", "Smierc jest blisko...",
            "Smierc nadchodzi...", "Smierc patrzy na ciebie...",
            "Smierc cie dopadla."
        };

        Random losuj = new Random();
        string haslo = slowa[losuj.Next(slowa.Length)];
        char[] odgadniete = new char[haslo.Length];

        for (int i = 0; i < haslo.Length; i++)
            odgadniete[i] = '_';

        int proby = 6;
        int zleStrzaly = 0;

        while (proby > 0 && !CzyZgadniete(odgadniete))
        {
            Console.WriteLine("\nSlowo: " + string.Join(" ", odgadniete));
            Console.WriteLine($"Pozostale proby: {proby}");
            Console.Write("Zgadnij litere: ");
            string wejscie = Console.ReadLine();

            if (string.IsNullOrEmpty(wejscie) || wejscie.Length != 1 || !char.IsLetter(wejscie[0]))
            {
                Console.WriteLine("Podaj tylko jedna litere alfabetu!");
                continue;
            }

            char litera = Char.ToLower(wejscie[0]);
            bool trafiono = false;

            for (int i = 0; i < haslo.Length; i++)
            {
                if (haslo[i] == litera)
                {
                    odgadniete[i] = litera;
                    trafiono = true;
                }
            }

            if (!trafiono)
            {
                Console.WriteLine(smierc[zleStrzaly]);
                zleStrzaly++;
                proby--;
            }
        }

        if (CzyZgadniete(odgadniete))
            Console.WriteLine($"\nBrawo! Haslo to: {haslo}");
        else
            Console.WriteLine($"\nNiestety, przegrales. Haslo to: {haslo}");
    }

    static bool CzyZgadniete(char[] tablica)
    {
        foreach (char c in tablica)
            if (c == '_') return false;
        return true;
    }
}
