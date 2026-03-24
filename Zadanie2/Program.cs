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
                    Console.WriteLine("Wybrano konwersję z °"+opcja);
                    // zastosowanie replace gdy uzytkownik wprowadzi , zamiast .
                    Console.Write("Podaj wartość: ");
                    string input = Console.ReadLine();
                    input = input.Replace(",",".");
                    double temp = double.Parse(input);
                    // Console.WriteLine(temp);
                    double wynik = 0;
                    // nadpisanie inputa do wyswietlenia wyniku wraz ze skalą 
                    if(opcja == "F" || opcja == "f")
                    {
                        wynik = (temp-32)/1.8;                        
                        Console.WriteLine("°F na °C");
                        input=wynik+"°C";
                    }
                    else if(opcja=="C" || opcja == "c")
                    {
                        wynik = temp * 1.8 + 32;
                        Console.WriteLine("°C na °F");
                        input=wynik+"°F";
                    }
                    Console.WriteLine($"Wynik konwersji to {input} ");
                }
                else
                {
                    throw new InvalidOperationException("nieznana skala wybierz F albo C");
                }           
            }
            catch(InvalidOperationException ex)
            {
                Console.WriteLine("Błąd: "+ex.Message);   
            }
            catch (FormatException)
            {
                Console.WriteLine("Błąd: wprowadzono zły format, wprowadź liczbę");   
            }
            catch
            {
                Console.WriteLine("Niespodziewany błąd");            
            }
        }
    }
