using Tabuleiro;

namespace KnightMove.Xadrez
{
    internal class Rei : Peca
    {
        public Rei(Cor cor, Tabuleiro.Tabuleiro tab) : base(cor, tab)
        {
        }

        public override string ToString()
        {
            return "R";
        }
    }
}
