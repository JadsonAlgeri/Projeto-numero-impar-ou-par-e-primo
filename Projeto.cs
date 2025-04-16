using System;

class Program
{
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
        while (true)
        {
            try
            {
                Console.Write("Digite um número (ou 'fechar' para fechar o programa): ");
                string entrada = Console.ReadLine() ?? "";

                if (entrada.ToLower() == "fechar")
                {
                    Console.WriteLine("Encerrando o programa...");
                    break;
                }

                if (int.TryParse(entrada, out int numero))
                {
                    if (numero % 2 == 0)
                        Console.WriteLine($"{numero} é um número Par.");
                    else
                        Console.WriteLine($"{numero} é um número Ímpar.");

                    if (Primos(numero))
                        Console.WriteLine($"{numero} é um número Primo.");
                    else
                        Console.WriteLine($"{numero} não é número Primo.");
                }
                else
                {
                    Console.WriteLine("Ops, caractere inválido. Por favor, digite apenas números!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
        }

        Console.WriteLine("Pressione qualquer tecla para fechar o programa...");
        Console.ReadKey();
    }
}
