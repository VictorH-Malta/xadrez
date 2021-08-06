using System;
using tabuleiro;
using xadrez;

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
                    ImprimirPeca(tab.Peca(i, j));//A Lógica está toda no método
                }
                //Ao terminar a linha, ocorre a quebra
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
        }

        public static void ImprimirTabuleiro(Tabuleiro tab, bool[,] posicoesPossiveis)
        {
            ConsoleColor fundoOriginal = Console.BackgroundColor;
            ConsoleColor fundoAlterado = ConsoleColor.DarkGray;

            Console.BackgroundColor = fundoOriginal;
            for (int i = 0; i < tab.Linhas; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < tab.Colunas; j++)
                {
                    if (posicoesPossiveis[i,j] == true)
                    {
                        Console.BackgroundColor = fundoAlterado;
                    }
                    else
                    {
                        Console.BackgroundColor = fundoOriginal;
                    }
                    
                    ImprimirPeca(tab.Peca(i, j));//A Lógica está toda no método
                }
                Console.BackgroundColor = fundoOriginal;
                //Ao terminar a linha, ocorre a quebra
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
            Console.BackgroundColor = fundoOriginal;
        }

        public static PosicaoXadrez LerPosicaoXadrez()
        {
            //Lê a posição que o usuário digitar;
            string s = Console.ReadLine();
            char coluna = s[0];
            int linha = int.Parse(s[1] + "");

            //retorna instanciando as posições
            return new PosicaoXadrez(coluna, linha);
        }

        //Método estático que diferencia e imprime as peças pretas como "Amarelas"
        public static void ImprimirPeca(Peca peca)
        {
            //Se não tiver peças na posição, imprime "-". Se houver, imprime a peça.
            if (peca == null)
            {
                Console.Write("- ");
            }
            else
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

                Console.Write(" ");
            }
        }
    }
}
