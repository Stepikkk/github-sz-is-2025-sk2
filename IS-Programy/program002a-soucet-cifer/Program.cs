﻿using System.Numerics;
    Console.Clear();
    Console.WriteLine("****************************");
    Console.WriteLine("***** Ciferný součet *****");
    Console.WriteLine("****************************");
    Console.WriteLine("******* Štěpán Závacký ********");
    Console.WriteLine("****************************");
    Console.WriteLine();

int cislo;
int soucet = 0;
Console.WriteLine("Zadej celé číslo, pro který počítáme ciferný součet.");
while (!int.TryParse(Console.ReadLine(), out cislo))
{
    Console.WriteLine("Zadaná hodnota není celé číslo.");
}

if (cislo < 0) cislo = -cislo;

foreach(char cislice in cislo.ToString())
{
    soucet += cislice - '0';
    Console.WriteLine("Přičítám číslo {0}. Aktuální hodnota: {1}", cislice, soucet);
}