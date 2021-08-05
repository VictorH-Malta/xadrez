namespace tabuleiro
{
    class Tabuleiro
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; } //O tabuleiro tem linhas e colunas
        private Peca[,] Pecas; //Tabuleiro tem peças

        public Tabuleiro(int linhas, int colunas)
        {
            Linhas = linhas;
            Colunas = linhas;
            //A matriz de peças terá a quantidade de linhas e colunas informada
            Pecas = new Peca[linhas, colunas];
        }

        //Este método foi criado para dar acesso à propriedade matriz Peca[,]
        public Peca Peca(int linha, int coluna)
        {
            return Pecas[linha, coluna];
        }

        //Método para incluir peça no tabuleiro
        public void ColocarPeca(Peca p, Posicao pos)
        {
            //guarda a posição indicada e manda para o tabuleiro
            Pecas[pos.Linha, pos.Coluna] = p;
            p.Posicao = pos;
        }

    }
}
