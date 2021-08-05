using System;
using tabuleiro;
using xadrez;

namespace xadrex_console
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tabuleiro de xadrez tem dimensão 8x8
            Tabuleiro tab = new Tabuleiro(8, 8);

            //Criando peças no tabuleiro através do método ColocarPeca()
            tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
            tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
            tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(2, 4));

            //chama a classe que imprime o tabuleiro na tela
            Tela.imprimirTabuleiro(tab);

        }
    }
}
