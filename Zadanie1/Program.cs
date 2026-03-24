using System;
﻿namespace Zadanie1;

    class ProstyKalkulator
    {
        static void Main(string[] args)
        {
            try
            {
            // zastosowanie int nie trzeba zmienoprzecinkowych (prosty kalkulator)
            // ewentualnie long ale int powinien w zupełności wystarczyć
                Console.Write("Podaj liczbę nr.1: ");           
                int a = int.Parse(Console.ReadLine());
                Console.Write("Podaj operator (+,-,*,/): ");           
                string op = Console.ReadLine();
                Console.Write("Podaj liczbę nr.2: ");           
                int b = int.Parse(Console.ReadLine());
                // Walidacja operatora
                if(op=="+" || op=="-" || op=="*" || op == "/")
                {
                    Console.WriteLine(op);
                }
                else
                {
                    // Dodanie błędu do catch
                    throw new InvalidOperationException("nieznany operator");
                }
            }
            catch(FormatException)
            {
                // błąd przy wprowadzaniu liczby
                Console.WriteLine("błędny format");
            }
            catch(InvalidOperationException ex)
            {
                Console.WriteLine("błąd: "+ex.Message);
            }
            catch
            {
                Console.WriteLine("błąd");
            }
            // rozpoznawanie ifem
        }
    }
