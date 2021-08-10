using tabuleiro;

namespace xadrez
{
    class Bispo : Peca
    {
        public Bispo(Tabuleiro tab, Cor cor) : base(tab, cor)
        {

        }

        public override string ToString()
        {
            return "B";
        }

        public bool PodeMover(Posicao pos)
        {
            Peca p = Tab.Peca(pos);
            return p == null || p.Cor != Cor;
        }

        public override bool[,] MovimentosPossiveis()
        {
            bool[,] mat = new bool[Tab.Linhas, Tab.Colunas];

            Posicao pos = new Posicao(0, 0);

            //NE
            pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna + 1);
            while (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                //A matriz recebe verdadeiro
                mat[pos.Linha, pos.Coluna] = true;
                //Se a posição não tiver nenhum elemento, E a cor que estiver lá for diferente, pare a execução
                if (Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor)
                {
                    break;
                }
                //Siga uma casa verticalmente
                pos.Linha -= 1;
                pos.Coluna += 1;
            }

            //SE
            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna + 1);
            while (Tab.PosicaoValida(pos) && PodeMover(pos))
            {

                mat[pos.Linha, pos.Coluna] = true;

                if (Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor)
                {
                    break;
                }

                pos.Linha += 1;
                pos.Coluna += 1;
            }

            //SO
            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna - 1);
            while (Tab.PosicaoValida(pos) && PodeMover(pos))
            {

                mat[pos.Linha, pos.Coluna] = true;

                if (Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor)
                {
                    break;
                }

                pos.Linha += 1;
                pos.Coluna -= 1;
            }

            //NO
            pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna - 1);
            while (Tab.PosicaoValida(pos) && PodeMover(pos))
            {

                mat[pos.Linha, pos.Coluna] = true;

                if (Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor)
                {
                    break;
                }

                pos.Linha -= 1;
                pos.Coluna -= 1;
            }

            return mat;
        }
    }
}
