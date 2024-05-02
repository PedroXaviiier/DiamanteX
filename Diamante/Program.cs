namespace Diamante
{
    internal class Program
    {
        static void Main(string[] args)
        {
       
            int tamanhoDiamante = 0;
            int meio;

            do
            {
                Console.WriteLine("Entre com um numero impar, para o tamanho do diamante:");
                tamanhoDiamante = Convert.ToInt16(Console.ReadLine());

                if (ValidarImpar(tamanhoDiamante) is false)
                {
                    Console.WriteLine("erro, número par");
                    return;
                }

                meio = tamanhoDiamante / 2;

                for (int i = 0; i <= meio; i++)
                {
                    PercorrerEspaçosVertical(tamanhoDiamante, meio, i);
                    Console.WriteLine();
                }

                for (int i = meio - 1; i >= 0; i--)
                {
                    PercorrerEspaçosVertical(tamanhoDiamante, meio, i);
                    Console.WriteLine();
                }
                Console.ReadKey();

            } 
            while (ValidarImpar(tamanhoDiamante));
        }

        private static void PercorrerEspaçosVertical(int tamanhoDiamante, int meio, int i)
        {
            for (int j = 0; j < tamanhoDiamante; j++)
            {
                ValidarDiamante(meio, i, j);
            }
        }

        private static void ValidarDiamante(int meio, int i, int j)
        {
            bool validarEsquerda = j >= meio - i;
            bool validarDireita = j <= meio + i;

            if (validarEsquerda && validarDireita)
            {
                Console.Write("X");
            }

            else
            {
                Console.Write(" ");
            }
        }

        static bool ValidarImpar(int numero)
        {
            return numero % 2 != 0;
        }
    }
}

