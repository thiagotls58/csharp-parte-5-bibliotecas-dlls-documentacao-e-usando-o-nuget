using System;
using Humanizer;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dataFimPagamento = new DateTime(2021, 01, 01);
            DateTime dataCorrente = DateTime.Now;

            TimeSpan diferenca = dataFimPagamento - dataCorrente;

            string mensagem = $"Vencimento em {TimeSpanHumanizeExtensions.Humanize(diferenca)}.";

            Console.WriteLine(mensagem);

            Console.ReadLine();
        }

        
    }
}
