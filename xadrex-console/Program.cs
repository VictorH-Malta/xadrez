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
                PartidaDeXadrez partida = new PartidaDeXadrez();

                //Enquanto tiver rolando ainda a partida de xadrez...
                while (!partida.Terminada)
                {
                    Console.Clear(); //Limpa o console
                    //chama a classe que imprime o tabuleiro na tela
                    Tela.ImprimirTabuleiro(partida.Tab);

                    Console.WriteLine();
                    Console.Write("Origem: ");
                    //Lê uma posição e guarda em uma variável origem
                    Posicao origem = Tela.LerPosicaoXadrez().ToPosicao();
                    Console.Write("Destino: ");
                    Posicao destino = Tela.LerPosicaoXadrez().ToPosicao();

                    partida.ExecutaMovimento(origem, destino);
                }

                

            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
