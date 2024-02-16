using System;
using System.Net.Http.Headers;

namespace uppgift6_9
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Meny();
                bool svar = int.TryParse(Console.ReadLine(), out int n);
                while (!svar || n > 3 || n < 1)
                {
                    Console.Write("Ogiltigt svar! Skriv 1, 2 eller 3: ");
                    svar = int.TryParse(Console.ReadLine(), out n);
                }
                if (n == 3)
                {
                    break;
                }
                Console.WriteLine();
                switch (n)
                {
                    case 1:
                        Console.Write("Skriv ett heltal: ");
                        bool svar2 = int.TryParse(Console.ReadLine(), out int heltal);
                        while (!svar2)
                        {
                            Console.Write($"Talet är inte ett heltal! Skriv ett heltal: ");
                            svar2 = int.TryParse(Console.ReadLine(), out heltal);
                        }
                        Console.WriteLine();
                        Primtal(heltal);
                        break;
                    case 2:
                        Console.Write("Skriv ett tal: ");
                        bool svar3 = double.TryParse(Console.ReadLine(), out double tal);
                        while (!svar3)
                        {
                            Console.Write($"Talet är inte ett giltigt tal! Skriv ett tal: ");
                            svar3 = double.TryParse(Console.ReadLine(), out tal);
                        }
                        Console.WriteLine();
                        AntalPrimtal(tal);
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
        static void Meny()
        {
            Console.WriteLine("1. Är n ett primtal?");
            Console.WriteLine("2. Antalet primtal mindre än n");
            Console.WriteLine("3. Avsluta programmet");
            Console.Write("Svar: ");
        }
        static bool ÄrPrimtal(int heltal)
        {
            for (int i = 2; i < heltal; i++)
            {
                if (heltal % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static void AntalPrimtal(double a)
        {
            int count = 0;
            for (int i = 0; i < a; i++)
            {
                if (i == 0 || i == 1)
                {
                    continue;
                }
                else if (ÄrPrimtal(i))
                {
                    count++;
                }
            }
            Console.WriteLine("Det finns " + count + " antal primtal mindre än " + a);
        }

        static void Primtal(int a)
        {
            bool prim = true;
            for (int i = 2; i < a; i++)
            {
                if (a % i == 0)
                {
                    prim = false;
                    break;
                }
            }
            if (prim)
            {
                Console.WriteLine(a + " är ett primtal.");
            }
            else
            {
                Console.WriteLine(a + " är inte ett primtal.");
            }
        }
    }
}