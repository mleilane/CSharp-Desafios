using System;
namespace Desafios
{
    class Desafio5
    {
        public static void Executar()
        {
            // Receber a string de entrada
            Console.WriteLine("Digite uma string para inverter:");
            string input = Console.ReadLine();

            // Variável para armazenar a string invertida
            string invertida = "";

            // Percorrer a string de trás para frente
            for (int i = input.Length - 1; i >= 0; i--)
            {
                invertida += input[i];  // Adiciona o caractere ao final da string invertida
            }

            // Exibir a string invertida
            Console.WriteLine($"String invertida: {invertida}");
        }
    }
}