using System;

class Program
{
    static void Main()
    {
        int largura, altura;

        Console.WriteLine("\t\t\tBora fazer um retângulo.");

        Console.WriteLine("Tamanho do retângulo:\nLargura..: ");
        largura = int.Parse(Console.ReadLine());

        Console.Write("Altura...: ");
        altura = int.Parse(Console.ReadLine());

        if (largura < 1 || largura > 10 || altura < 1 || altura > 10)
        {
            Console.WriteLine("Erro: altura e largura devem estar entre 1 e 10.");
            return;
        }

        Console.WriteLine();

        for (int i = 0; i < altura; i++)
        {
            for (int j = 0; j < largura; j++)
            {
                if (i == 0 || i == altura - 1 || j == 0 || j == largura - 1)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}