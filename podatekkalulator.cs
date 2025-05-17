Console.WriteLine("Witam w programie do obliczania podatku dochodowego!");
Console.WriteLine("Proszę o podanie swojego rocznego dochodu:");
double dochod = double.Parse(Console.ReadLine());
double podatek = 0;

if (dochod <= 10000)
{
    podatek = 0;
}
else if (dochod <= 30000)
{
    podatek = (dochod - 10000) * 0.10;
}
else if (dochod <= 100000)
{
    podatek = (30000 - 10000) * 0.10;
    podatek += (dochod - 30000) * 0.20;
}
else
{
    podatek = (30000 - 10000) * 0.10;
    podatek += (100000 - 30000) * 0.20;
    podatek += (dochod - 100000) * 0.30;
}

Console.WriteLine("Twój podatek wynosi: " + Math.Round(podatek, 2) + " PLN, Twój dochód wynosi: " + dochod + " PLN.");
