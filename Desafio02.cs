

namespace Desafios
{
    class Desafio2
    {
        public static void Executar()
        {
            Console.WriteLine("Digite um número para verificar se pertence ou não a sequencia de Fibonacci:");
            int numero = int.Parse(Console.ReadLine());

            int a = 0, b = 1, c = 0;

            //Calcula a sequência de Fibonacci até que c seja maior ou igual ao nº informado 
            while (c < numero)
            {
                c = a + b;
                a = b;
                b = c;
            }

            //Verifica se o numero pertence a sequência
            if (c == numero || numero == 0)
            {
                Console.WriteLine($"O número {numero} pertence à sequencia de Fibonacci.");
            }
            else
            {
                Console.WriteLine($"O número {numero} não pertence à sequencia de Fibonacci.");

            }

        }
    }
}