using tabuleiro;

namespace xadrez
{
    class Torre : Peca
    {
        public Torre(Tabuleiro tab, Cor cor) : base(tab, cor)
        {

        }

        public override string ToString()
        {
            return "T";
        }

        private bool PodeMover(Posicao pos)
        {
            Peca p = Tab.Peca(pos);
            return p == null || p.Cor != Cor;
        }

        public override bool[,] MovimentosPossiveis()
        {
            bool[,] mat = new bool[Tab.Linhas, Tab.Colunas];

            Posicao pos = new Posicao(0, 0);

            //acima
            pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna);
            //Enquanto a posição for válida e o movimento puder acontecer, então
            while (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                //A matriz recebe verdadeiro
                mat[pos.Linha, pos.Coluna] = true;
                //Se a posição não tiver nenhum elemento, ou a cor que estiver lá for diferente, pare a execução
                if (Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor)
                {
                    break;
                }
                //Siga uma casa verticalmente
                pos.Linha -= 1;
            }

            //abaixo
            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna);
            //Enquanto a posição for válida e o movimento puder acontecer, então
            while (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                //A matriz recebe verdadeiro
                mat[pos.Linha, pos.Coluna] = true;
                //Se a posição não tiver nenhum elemento, ou a cor que estiver lá for diferente, pare a execução
                if (Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor)
                {
                    break;
                }
                //Siga uma casa verticalmente
                pos.Linha += 1;
            }

            //direita
            pos.DefinirValores(Posicao.Linha, Posicao.Coluna + 1);
            //Enquanto a posição for válida e o movimento puder acontecer, então
            while (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                //A matriz recebe verdadeiro
                mat[pos.Linha, pos.Coluna] = true;
                //Se a posição não tiver nenhum elemento, ou a cor que estiver lá for diferente, pare a execução
                if (Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor)
                {
                    break;
                }
                //Siga uma casa horizontalmente
                pos.Coluna += 1;
            }

            //esquerda
            pos.DefinirValores(Posicao.Linha, Posicao.Coluna - 1);
            //Enquanto a posição for válida e o movimento puder acontecer, então
            while (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                //A matriz recebe verdadeiro
                mat[pos.Linha, pos.Coluna] = true;
                //Se a posição não tiver nenhum elemento, ou a cor que estiver lá for diferente, pare a execução
                if (Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor)
                {
                    break;
                }
                //Siga uma casa horizontalmente
                pos.Coluna -= 1;
            }

            return mat;
        }
    }
}
