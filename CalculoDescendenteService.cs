using System;

namespace OrdenacaoNumeroInteiro
{
    public class CalculoDescendenteService
    {
        public int CalculoDescendente(int tamanhoNumero, int numero)
        {
            int[] digitos = new int[tamanhoNumero];

            for (int i = 0; i < tamanhoNumero; i++)
            {
                digitos[i] = (numero % 10);
                numero /= 10;
            }

            Array.Sort(digitos);

            int numeroDescendente = 0;
            for (int i = tamanhoNumero - 1; i >= 0; i--)
            {
                numeroDescendente = numeroDescendente * 10 + digitos[i];
            }
            Console.Write("Seu número é: " + numeroDescendente);
            return numero;
        }
    }
}
