using System;
using tabuleiro;
using xadrez;

namespace xadrex_console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Tabuleiro de xadrez tem dimensão 8x8
                Tabuleiro tab = new Tabuleiro(8, 8);

                //Criando peças no tabuleiro através do método ColocarPeca(Peca p, Posicao pos)
                tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
                tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 2));

                tab.ColocarPeca(new Torre(tab, Cor.Branca), new Posicao(6, 3));
                tab.ColocarPeca(new Torre(tab, Cor.Branca), new Posicao(5, 5));
                tab.ColocarPeca(new Rei(tab, Cor.Branca), new Posicao(7, 1));

                //chama a classe que imprime o tabuleiro na tela
                Tela.ImprimirTabuleiro(tab);

            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
