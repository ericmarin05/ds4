﻿using System;

internal class Program
{
    private static void Main(string[] args)
    {
        string[] frutas = { "manzana", "Platano", "platano", "naranja" };
        foreach (string fruta in frutas) 
        { 
           Console.WriteLine(fruta);
        }

    }
}