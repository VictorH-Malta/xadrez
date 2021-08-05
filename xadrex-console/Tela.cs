using System;
using tabuleiro;

namespace xadrex_console
{
    class Tela
    {
        //Classe feita para imprimir o tabuleiro na tela, criando de acordo com as propriedades indicadas de linhas e colunas.
        public static void ImprimirTabuleiro(Tabuleiro tab)
        {
            //Cria uma matriz de linhas e colunas que imprime os tracinhos e peças no tabuleiro
            for (int i = 0; i < tab.Linhas; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < tab.Colunas; j++)
                {
                    
                    //Se não tiver peças na posição, imprime "-". Se houver, imprime a peça.
                    if (tab.Peca(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        ImprimirPeca(tab.Peca(i, j));
                        Console.Write(" ");
                    }
                }
                //Ao terminar a linha, ocorre a quebra
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
        }

        //Método estático que diferencia e imprime as peças pretas como "Amarelas"
        public static void ImprimirPeca(Peca peca)
        {
            if (peca.Cor == Cor.Branca)
            {
                Console.Write(peca);
            }
            else
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write(peca);
                Console.ForegroundColor = aux;
            }
        }
    }
}
