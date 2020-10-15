using System;

namespace OrdenacaoNumeroInteiro
{
    public static class Program
    {
        public static void Main()
        {
            var _svc = new CalculoDescendenteService();

            try
            {
                Console.Write("Insira um número inteiro: ");
                var numeroRecebido = Console.ReadLine();

                var tamanhoNumero = numeroRecebido.Length;

                if (tamanhoNumero >= 8)
                {
                    Console.Write("O Seu retorno é: -1");
                    Console.ReadKey();
                }
                else
                {
                    var numero = Convert.ToInt32(numeroRecebido);
                    _svc.CalculoDescendente(tamanhoNumero, numero);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Verifique o numero inserido e tente novamente.");
            }
        }
    }
}