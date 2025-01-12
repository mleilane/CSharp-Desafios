using System;
using Desafios;

class Program
{
    static void Main()
    {
        Console.WriteLine("Escolha o desafio para executar (1 a 5):");
        int escolha = int.Parse(Console.ReadLine());

        switch (escolha)
        {
            case 1:
                Desafio1.Executar();
                break;
            case 2:
                Desafio2.Executar();
                break;
            case 3:
                Desafio3.Executar();
                break;
            case 4:
                Desafio4.Executar();
                break;
            case 5:
                Desafio5.Executar();
                break;
            default:
                Console.WriteLine("Escolha inválida");
                break;
        }
    }
}

