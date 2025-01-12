namespace Desafios
{
    public class Desafio1
    {
        public static void Executar()
        {
            int INDICE = 13, SOMA = 0, K = 0;

            while (K < INDICE)
            {
                K = K + 1;
                SOMA = SOMA + K;
            }
            Console.WriteLine($"O valor da final da Soma é: {SOMA}");
        }

    }

}