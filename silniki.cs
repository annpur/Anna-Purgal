using System;

public class Silnik{
    public int Moc { get; set; }
    public string Typ { get; set; }
    
    public Silnik(int moc, string typ){
        Moc = moc;
        Typ = typ;
    }
    public Silnik(Silnik inny){
        Moc = inny.Moc;
        Typ = inny.Typ;
    }
}

public class Kolo{
    public int rozmiar { get; set; }
    public string Typ { get; set; }

    public Kolo(int rozmiar, string typ){
        rozmiar = rozmiar;
        Typ = typ;
    }
    public Kolo(Kolo inne){
        rozmiar = inne.rozmiar;
        Typ = inne.Typ;
    }
}

public class Samochod{
    public string marka { get; set; }
    public Silnik Silnik { get; set; }
    public Kolo[] Kola { get; set; }

    public Samochod(string marka, Silnik silnik,Kolo[] kola){
        marka = marka;
        Silnik = silnik;
        Kola = kola;
    }

    public static Samochod Kopiuj(Samochod samochod){
        Silnik silnikKopia = new Silnik(samochod.Silnik);
        Kolo[] kolaKopia = new Kolo[samochod.Kola.Length];
        
        for (int i=0; i<samochod.Kola.Length; i++){
            kolaKopia[i] = new Kolo(samochod.Kola[i]);
        }
        
        return new Samochod(samochod.Marka, silnikKopia, kolaKopia);
    }
}

public class Program{
    public static void WypiszSamochod(Samochod samochod){
        Console.WriteLine($"Marka: {samochod.Marka}");
        Console.WriteLine($"Silnik: {samochod.Silnik.Moc} KM, Typ: {samochod.Silnik.Typ}");
        for (int i=0; i<samochod.Kola.Length; i++){
            Console.WriteLine($"Kolo {i + 1}: Rozmiar {samochod.Kola[i].Rozmiar}, Typ: {samochod.Kola[i].Typ}");
        }
        Console.WriteLine("\n");
    }
    public static void Main(){
        Samochod samochod1 = new Samochod(
            "BMW",
            new Silnik(150, "Diesel"),
            new Kolo[]{
                new Kolo(16, "letnie"),
                new Kolo(16, "Letnie"),
                new Kolo(16, "Letnie"),
                new Kolo(16, "Letnie")
            }
        );
        Samochod samochod2 = Samochod.Kopiuj(samochod1);
        // Samochod samochod3 = Samochod.Kopiuj(samochod1);
        Console.WriteLine("Samochod 1: ");
        WypiszSamochod(samochod1);
        
        // samochod2.Marka = "Audi";
        // samochod2.Silnik.Moc = 250;
        // samochod2.Kola[0].Rozmiar = 18;
        
        Console.WriteLine("Samochod 2: ");
        WypiszSamochod(samochod2);
        
    }
}
