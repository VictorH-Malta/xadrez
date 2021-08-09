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
                    try
                    {
                        Console.Clear(); //Limpa o console        
                        Tela.ImprimirPartida(partida);//chama a classe que imprime o tabuleiro na tela

                        Console.WriteLine();
                        Console.Write("Origem: ");
                        //Lê uma posição e guarda em uma variável origem
                        Posicao origem = Tela.LerPosicaoXadrez().ToPosicao();
                        partida.ValidarPosicaoDeOrigem(origem);

                        bool[,] posicoesPossiveis = partida.Tab.Peca(origem).MovimentosPossiveis();
                        Console.Clear(); //Limpa o console
                                         //chama a classe que imprime o tabuleiro na tela
                        Tela.ImprimirTabuleiro(partida.Tab, posicoesPossiveis);

                        Console.WriteLine();
                        Console.Write("Destino: ");
                        Posicao destino = Tela.LerPosicaoXadrez().ToPosicao();
                        partida.ValidarPosicaoDeDestino(origem, destino);

                        partida.RealizaJogada(origem, destino);
                    }
                    catch (TabuleiroException e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }
                }
                Console.Clear(); //Limpa o console        
                Tela.ImprimirPartida(partida);

            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
