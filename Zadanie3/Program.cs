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
                    if (ocena>=1 && ocena<=6){
                        suma += ocena;
                    }
                    else
                    {
                        Console.WriteLine("Wprowadzono złą liczbe, skala to (od 1 do 6)");
                        return;
                    }
                }
                suma /= licznik;
                if(suma >= 3)
                {
                    Console.WriteLine("Brawo zdałeś twoja średnia to: "+suma);
                }
                else
                {
                    Console.WriteLine("Niestety nie zdałeś twoja średnia to: "+suma);
                    Console.WriteLine($"Brakło ci {3-suma} do zdania");                    
                }
            }
            catch
            {
                Console.WriteLine("Niespodziewany błąd");            
            }
        }
    }
