using System;

class Program
{
    static int BuscaBinaria(int[] arr, int alvo)
    {
        int esquerda = 0, direita = arr.Length - 1;

        while (esquerda <= direita)
        {
            int meio = (esquerda + direita) / 2;

            if (arr[meio] == alvo)
                return meio; 
            else if (arr[meio] < alvo)
                esquerda = meio + 1;
            else
                direita = meio - 1;
        }

        return -1; 
    }

    static void Main()
    {
        int[] numeros = { 1, 3, 5, 7, 9, 11, 13, 15 };
        int procurado = 7;
        int indice = BuscaBinaria(numeros, procurado);
        Console.WriteLine($"O número {procurado} está no índice {indice}.");
    }
}

