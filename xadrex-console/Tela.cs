using System;
using tabuleiro;

namespace xadrex_console
{
    class Tela
    {
        //Classe feita para imprimir o tabuleiro na tela, criando de acordo com as propriedades indicadas de linhas e colunas.
        public static void imprimirTabuleiro(Tabuleiro tab)
        {
            //Cria uma matriz de linhas e colunas que imprime os tracinhos e peças no tabuleiro
            for (int i = 0; i < tab.Linhas; i++)
            {
                for (int j = 0; j < tab.Colunas; j++)
                {
                    //Se não tiver peças na posição, imprime "-". Se houver, imprime a peça.
                    if (tab.Peca(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write(tab.Peca(i, j) + " ");
                    }
                }
                //Ao terminar a linha, ocorre a quebra
                Console.WriteLine();
            }
        }
    }
}
