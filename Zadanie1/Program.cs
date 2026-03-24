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
                    int wynik = 0;
                    if (op == "+")
                    {
                        wynik=a+b;
                    }
                    else if (op == "-")
                    {
                        wynik=a-b;
                    }
                    else if (op == "*")
                    {
                        wynik=a*b;
                    }
                    else if (op == "/")
                    {
                        // walidacja dzielenia przez 0
                        if(b!=0)
                        {
                            wynik=a/b;
                        }
                        else
                        {
                            throw new DivideByZeroException("dzielenie przez zero");
                        }
                    }
                    Console.WriteLine($"Wynik działania: {a} {op} {b} = {wynik}");
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
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("błąd: "+ex.Message);
            }
            catch
            {
                Console.WriteLine("Niespodziewany błąd");            
            }
            // rozpoznawanie ifem
        }
    }
