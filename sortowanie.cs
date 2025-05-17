using System;

public class Student
{
    public string imie { get; set; }
    public string nazwisko { get; set; }
    public string numerIndeksu { get; set; }

    public Student(string i, string n, string ni){
        imie = i;
        nazwisko = n;
        numerIndeksu = ni;
    }
    public string Opis(){
        return $"{imie} {nazwisko}, nr indeksu: {numerIndeksu}";
    }
}

public class Kurs{
    public string nazwaKursu { get; set; }
    public int maksymalnaLiczbaStudentow { get; set; }
    private Student[] studenci;
    private int liczbaZapisanych = 0;

    public Kurs(string nk, int mls){
        nazwaKursu = nk;
        maksymalnaLiczbaStudentow = mls;
        studenci = new Student[mls];
    }
    public void ZapiszStudenta(Student student){
        if (liczbaZapisanych < maksymalnaLiczbaStudentow){
            studenci[liczbaZapisanych] = student;
            liczbaZapisanych++;
            Console.WriteLine($"Zapisano studenta: {student.Opis()}");
        }else{
            Console.WriteLine("Nie mozna zapisac studenta. kurs jest pelny.");
        }
    }

    public void WypiszListeStudentow(){
        Console.WriteLine($"\nLista studentow zapisanych na kurs {nazwaKursu}:");
        for (int i=0; i<liczbaZapisanych; i++){
            Console.WriteLine(studenci[i].Opis());
        }
    }
}

public class Program{
    public static void Main(){
        Kurs kurs = new Kurs("Programowanie", 3);

        Student s1 = new Student("Jan", "Kowalski", "12345");
        Student s2 = new Student("Anna", "Nowak", "67890");
        Student s3 = new Student("Piotr", "Zielinski", "98765");
        Student s4 = new Student("Adam", "Malysz", "43210");

        kurs.ZapiszStudenta(s1);
        kurs.ZapiszStudenta(s2);
        kurs.ZapiszStudenta(s3);
        kurs.ZapiszStudenta(s4);

        kurs.WypiszListeStudentow();


    }
}
