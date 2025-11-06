﻿using System;

class Program
{
    static void Main()
    {
        string znovu = "a";

        while (znovu == "a")
        {
            Console.Clear();
            Console.WriteLine("===================================");
            Console.WriteLine("===== Generátor ASCII obrazců =====");
            Console.WriteLine("===================================");
            Console.WriteLine("========== Štěpán Závacký =========");
            Console.WriteLine("============= 3.11.2025 ===========");
            Console.WriteLine();

            Console.WriteLine("Vyberte, co chcete vykreslit:");
            Console.WriteLine("1 - Obdélník");
            Console.WriteLine("2 - Trojúhelník (pravouhlý)");
            Console.WriteLine("3 - Písmeno N");
            Console.WriteLine("4 - Obrácené písmeno N");
            Console.WriteLine("5 - Diamant");
            Console.Write("Vaše volba (1–5): ");

            int volba;
            while (!int.TryParse(Console.ReadLine(), out volba) || volba < 1 || volba > 5)
            {
                Console.Write("Neplatný vstup. Zadejte číslo mezi 1 a 5: ");
            }

            Console.WriteLine();

            switch (volba)
            {
                case 1:
                    Obdelnik();
                    break;
                case 2:
                    Trojuhelnik();
                    break;
                case 3:
                    PismenoN();
                    break;
                case 4:
                    PismenoNObracene();
                    break;
                case 5:
                    Diamant();
                    break;
            }

            Console.WriteLine();
            Console.Write("Chcete pokračovat? (a = ano / jinak konec): ");
            znovu = Console.ReadLine()?.ToLower();
        }
    }

    static int ZadejCislo(string vyzva)
    {
        int hodnota;
        Console.Write(vyzva);
        while (!int.TryParse(Console.ReadLine(), out hodnota) || hodnota <= 0)
        {
            Console.Write("Zadejte prosím celé číslo větší než 0: ");
        }
        return hodnota;
    }

    static void Obdelnik()
    {
        int sirka = ZadejCislo("Zadejte šířku: ");
        int vyska = ZadejCislo("Zadejte výšku: ");

        for (int y = 0; y < vyska; y++)
        {
            for (int x = 0; x < sirka; x++)
            {
                Console.Write("*");
                System.Threading.Thread.Sleep(25);
            }
            Console.WriteLine();
        }
    }

    static void Trojuhelnik()
    {
        int velikost = ZadejCislo("Zadejte velikost trojúhelníku: ");

        for (int i = 1; i <= velikost; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
                System.Threading.Thread.Sleep(25);
            }
            Console.WriteLine();
        }
    }

    static void PismenoN()
    {
        int velikost = ZadejCislo("Zadejte velikost písmene N: ");

        for (int i = 0; i < velikost; i++)
        {
            for (int j = 0; j < velikost; j++)
            {
                if (j == 0 || j == velikost - 1 || j == i)
                    Console.Write("*");
                else
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
    }

    static void PismenoNObracene()
    {
        int velikost = ZadejCislo("Zadejte velikost obráceného písmene N: ");

        for (int i = 0; i < velikost; i++)
        {
            for (int j = 0; j < velikost; j++)
            {
                if (j == 0 || j == velikost - 1 || j == (velikost - i - 1))
                    Console.Write("*");
                else
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
    }

    static void Diamant()
    {
        int n = ZadejCislo("Zadejte velikost diamantu (nejlépe liché číslo): ");
        if (n % 2 == 0) n++; // pokud uživatel zadá sudé číslo, automaticky se zvýší o 1
        int stred = n / 2;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (Math.Abs(i - stred) + Math.Abs(j - stred) == stred)
                    Console.Write("*");
                else
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}