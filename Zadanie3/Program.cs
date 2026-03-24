using System;
﻿namespace Zadanie2;

    class KonwerterTemperatur
    {
        static void Main(string[] args)
        { 
            // średnia ocen > 3.0
            // sumowanie i podzielenie przez ich ilosc
            try
            {
                Console.Write("Podaj liczbe ocen: ");
                byte licznik = byte.Parse(Console.ReadLine());
                double suma = 0;
                // Console.WriteLine(licznik);
                for (byte i=1; i<=licznik; i++)
                {
                    Console.Write($"Wpisz ocene nr.{i}: ");
                    // zamiana , na .
                    string input = Console.ReadLine();
                    input = input.Replace(",",".");
                    double ocena = double.Parse(input);
                    suma += ocena;
                }
                Console.WriteLine(suma);            
            }
            catch
            {
                Console.WriteLine("Niespodziewany błąd");            
            }
        }
    }
