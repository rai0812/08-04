using System;

class Program
{
    static int ContarOcorrencias(int[] arr, int elemento)
    {
        int contador = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == elemento)
            {
                contador++;
            }
        }
        return contador; 
    }

    static void Main()
    {
        int[] arr = { 10, 20, 30, 40, 50, 30, 10, 30 };
        int elemento = 30;
        int resultado = ContarOcorrencias(arr, elemento);
        Console.WriteLine($"O elemento {elemento} aparece {resultado} vezes no array.");
    }
}

