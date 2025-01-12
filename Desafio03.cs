namespace Desafios
{
    class Desafio3
    {
        public static void Executar()
        {
            double[] faturamento = { 1500, 5000, 3000, 500, 4000, 2000}; //fatuamento diario

            //Encontrar menor valor de faturamento
            double menorFaturamento = double.MaxValue;
            foreach (double valor in faturamento) 
            {
                if(valor < menorFaturamento)
                {
                    menorFaturamento = valor;
                }
            }

            //Encontrar maior valor de faturamento
            double maiorFaturamento = double.MinValue;
           foreach (double valor in faturamento)
            {
                if (valor > maiorFaturamento)
                {
                    maiorFaturamento = valor;
                }
            }

            //Calcular a média mensal 
            double somaFaturamento = 0;
            foreach (double valor in faturamento)
            {
                somaFaturamento += valor;
            }
            double mediaMensal = somaFaturamento/faturamento.Length;

            //Dias com faturamento superior a media mensal 
            int diasAcimaMedia = 0;
            foreach(double valor in faturamento)
            {
                if(valor > mediaMensal)
                {
                    diasAcimaMedia++;
                }
            }

            // Exibir os resultados
            Console.WriteLine($"Menor faturamento diário: R$ {menorFaturamento:F2}");
            Console.WriteLine($"Maior faturamento diário: R$ {maiorFaturamento:F2}");
            Console.WriteLine($"Média mensal de faturamento: R$ {mediaMensal:F2}");
            Console.WriteLine($"Número de dias com faturamento acima da média: {diasAcimaMedia}");
        }
    }
}