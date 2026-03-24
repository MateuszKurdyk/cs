using System;
﻿namespace Zadanie2;

    class KonwerterTemperatur
    {
        static void Main(string[] args)
        { 
            // F na C albo C na F
            try
            {
                Console.Write("Podaj skale F/C ");
                string opcja = Console.ReadLine();

                if(opcja == "F" || opcja=="f" || opcja=="C" || opcja == "c")
                {
                    Console.WriteLine(opcja);
                    if(opcja == "F" || opcja == "f")
                    {
                        Console.WriteLine("F na C");
                    }
                    else if(opcja=="C" || opcja == "c")
                    {
                        Console.WriteLine("C na F");
                    }
                }
                else
                {
                    throw new InvalidOperationException("nieznana skala");
                }           
            }
            catch(InvalidOperationException ex)
            {
                Console.WriteLine("Błąd: "+ex.Message);   
            }
            catch
            {
                Console.WriteLine("Niespodziewany błąd");            
            }
        }
    }
