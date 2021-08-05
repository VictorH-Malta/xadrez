using System;
using tabuleiro;

namespace xadrex_console
{
    class Tela
    {
        //Classe feita para imprimir o tabuleiro na tela, criando de acordo com as propriedades indicadas de linhas e colunas.
        public static void imprimirTabuleiro(Tabuleiro tab)
        {
            for (int i = 0; i < tab.Linhas; i++)
            {
                for (int j = 0; j < tab.Colunas; j++)
                {
                    if (tab.Peca(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write(tab.Peca(i, j) + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
