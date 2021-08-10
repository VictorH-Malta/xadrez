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

        //Este método foi criado para dar acesso à propriedade matriz Peca[,] que é private
        public Peca Peca(int linha, int coluna)
        {
            return Pecas[linha, coluna];
        }

        //Sobrecarga de método que recebe como parâmetro a posição
        public Peca Peca(Posicao pos)
        {
            return Pecas[pos.Linha, pos.Coluna];
        }

        //Método que confere existência de Peças no lugar
        public bool ExistePeca(Posicao pos)
        {
            ValidarPosicao(pos);
            return Peca(pos) != null;
        }

        //Método para incluir peça no tabuleiro
        public void ColocarPeca(Peca p, Posicao pos)
        {
            if (ExistePeca(pos))
            {
                throw new TabuleiroException("Já existe uma peça nessa posição!");
            }
            //guarda a posição indicada e manda para o tabuleiro
            Pecas[pos.Linha, pos.Coluna] = p;
            p.Posicao = pos;
        }

        public Peca RetirarPeca(Posicao pos)
        {
            if (Peca(pos) == null)
            {
                return null;
            }
            Peca aux = Peca(pos);
            aux.Posicao = null;
            Pecas[pos.Linha, pos.Coluna] = null;
            return aux;
        }

        //Implementando método que confere se a posição está dentro da matriz do tabuleiro 8x8
        public bool PosicaoValida(Posicao pos)
        {
            if (pos.Linha < 0 || pos.Linha >= Linhas || pos.Coluna < 0 || pos.Coluna >= Colunas)
            {
                return false;
            }
            return true;
        }

        //Método que gera excessão personalizada.
        public void ValidarPosicao(Posicao pos)
        {
            if (!PosicaoValida(pos))
            {
                throw new TabuleiroException("Posição inválida!");
            }
        }
    }
}
