﻿List<int> numeros = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

Console.WriteLine("Números Pares:\n");
foreach (int numero in numeros)
{
    if (numero % 2 == 0)
    {
        Console.WriteLine(numero);
    }
}