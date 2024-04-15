// Definizione dell'interfaccia:

// Crea un'interfaccia chiamata IFormaGeometrica.
// All'interno dell'interfaccia, dichiara due metodi: CalcolaArea() e CalcolaPerimetro(). Questi metodi dovrebbero restituire valori double.
// Implementazione delle classi:

// Crea una classe Rettangolo che implementi l'interfaccia IFormaGeometrica.
// Aggiungi proprietà per rappresentare la base e l'altezza del rettangolo.
// Implementa i metodi CalcolaArea() e CalcolaPerimetro() per il rettangolo.
// Crea una classe Cerchio che implementi l'interfaccia IFormaGeometrica.
// Aggiungi una proprietà per rappresentare il raggio del cerchio.
// Implementa i metodi CalcolaArea() e CalcolaPerimetro() per il cerchio.
// Main:

// Nel metodo Main, crea istanze di oggetti rettangolo e cerchio.
// Chiedi all'utente di inserire le dimensioni del rettangolo e del cerchio.
// Chiama i metodi CalcolaArea() e CalcolaPerimetro() per calcolare e visualizzare l'area e il perimetro di ciascuna forma.
// Test:

// Esegui il programma e verifica che i calcoli dell'area e del perimetro siano corretti per entrambe le forme geometriche.
// Questa traccia ti darà una guida per creare un programma che calcola l'area e il perimetro di rettangoli e cerchi utilizzando interfacce in C#. Buona codifica!

using System;

using System;

public interface IFormaGeometrica
{
    double CalcolaArea();
    double CalcolaPerimetro();
}

public class Rettangolo : IFormaGeometrica
{
    public double BaseRettangolo { get; set; }
    public double AltezzaRettangolo { get; set; }

    public Rettangolo(double baseRettangolo, double altezzaRettangolo)
    {
        BaseRettangolo = baseRettangolo;
        AltezzaRettangolo = altezzaRettangolo;
    }

    public double CalcolaArea()
    {
        return BaseRettangolo * AltezzaRettangolo;
    }

    public double CalcolaPerimetro()
    {
        return 2 * (BaseRettangolo + AltezzaRettangolo);
    }
}

public class Cerchio : IFormaGeometrica
{
    public double RaggioCerchio { get; set; }

    public Cerchio(double raggioCerchio)
    {
        RaggioCerchio = raggioCerchio;
    }

    public double CalcolaArea()
    {
        return Math.PI * RaggioCerchio * RaggioCerchio;
    }

    public double CalcolaPerimetro()
    {
        return 2 * Math.PI * RaggioCerchio;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Scegli cosa calcolare:");
            Console.WriteLine("1. Rettangolo");
            Console.WriteLine("2. Cerchio");
            Console.WriteLine("3. Esci");

            Console.Write("Scelta: ");
            string scelta = Console.ReadLine();

            switch (scelta)
            {
                case "1":
                    CalcolaRettangolo();
                    break;
                case "2":
                    CalcolaCerchio();
                    break;
                case "3":
                    Console.WriteLine("Ciao!");
                    return;
                default:
                    Console.WriteLine("Scelta non valida. Riprova.");
                    break;
            }
        }
    }

    public static void CalcolaRettangolo()
    {
        double baseRettangolo, altezzaRettangolo;

        do
        {
            Console.WriteLine("\nInserisci le dimensioni del rettangolo:");
            Console.Write("Base: ");
        } while (!double.TryParse(Console.ReadLine(), out baseRettangolo));

        do
        {
            Console.Write("Altezza: ");
        } while (!double.TryParse(Console.ReadLine(), out altezzaRettangolo));

        Rettangolo rettangolo = new Rettangolo(baseRettangolo, altezzaRettangolo);

        Console.WriteLine("\nArea e perimetro del rettangolo:\n");
        Console.WriteLine("Area: " + rettangolo.CalcolaArea());
        Console.WriteLine("Perimetro: " + rettangolo.CalcolaPerimetro());
        Console.WriteLine();
    }

    public static void CalcolaCerchio()
    {
        double raggioCerchio;

        do
        {
            Console.WriteLine("\nInserisci il raggio del cerchio:");
        } while (!double.TryParse(Console.ReadLine(), out raggioCerchio));

        Cerchio cerchio = new Cerchio(raggioCerchio);

        Console.WriteLine("\nArea e perimetro del cerchio:\n");
        Console.WriteLine("Area: " + cerchio.CalcolaArea());
        Console.WriteLine("Perimetro: " + cerchio.CalcolaPerimetro());
        Console.WriteLine();
    }
}



