using System;

class Program
{
    //Referência aos números primos e não primos
    static bool Primos(int numero)
    {
        if (numero <= 1) return false;
        if (numero == 2) return true;
        for (int i = 2; i <= Math.Sqrt(numero); i++)
        { 
            if (numero % i == 0)
                return false;
        }

        return true;
    }
    static void Main()
    {
        try
        {
            Console.Write("Digite um número: ");
            string entrada = Console.ReadLine() ?? "";
            if (int.TryParse(entrada, out int numero))
            {
                //Números impares e pares
                if (numero % 2 == 0)
                    Console.WriteLine($"{numero} é Par.");
                else
                    Console.WriteLine($"{numero} é Ímpar.");

                //Números primos e não primos
                if (Primos(numero))
                    Console.WriteLine($"{numero} é Primo.");
                else
                    Console.WriteLine($"{numero} não é Primo.");
            }
            else
            {
                Console.WriteLine("Valor inválido. Por favor, digite um número!");
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Ocorrreu um erro inesperado!");
        }
        Console.ReadKey();
    }
}
