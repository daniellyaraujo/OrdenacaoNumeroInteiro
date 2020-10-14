using System;

namespace OrdenacaoNumeroInteiro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            var numero = Console.ReadLine();
            var tamanho = numero.Length;
            int numero1 = int.Parse(numero);

            if (numero1 >= 10000000)
            {
                Console.Write("Seu número é: ");
                Console.WriteLine("-1");
            }
            else
            {
                int[] digitos = new int[tamanho];

                for (int i = 0; i < tamanho; i++)
                {
                    digitos[i] = numero1 % 10;
                    numero1 = numero1 / 10;
                }

                Array.Sort(digitos);
                int valorDescendente = 0;
                for (int i = tamanho - 1; i >= 0; i--)
                {
                    valorDescendente = valorDescendente * 10 + digitos[i];
                }
                Console.Write("Seu número é: ");
                Console.WriteLine(valorDescendente);
            }
        }
    }
}