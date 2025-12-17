using KnightMove.Xadrez;
using Tabuleiro;
using Xadrez;

namespace KnightMove
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                char a = 'a';
                int num = a;
                Console.WriteLine(num);

                PosicaoXadrez posicao = new PosicaoXadrez('c', 7);

                Console.WriteLine(posicao);
                Console.WriteLine(posicao.ToPosicao());

                Tabuleiro.Tabuleiro tabuleiro = new Tabuleiro.Tabuleiro(8, 8);

                tabuleiro.ColocarPeca(new Posicao(0, 0), new Torre(Cor.Branca, tabuleiro));
                tabuleiro.ColocarPeca(new Posicao(0, 3), new Torre(Cor.Branca, tabuleiro));
                tabuleiro.ColocarPeca(new Posicao(2, 2), new Rei(Cor.Branca, tabuleiro));

                Tela.ImprimirTabuleiro(tabuleiro);
            }
            catch (TabuleiroException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}