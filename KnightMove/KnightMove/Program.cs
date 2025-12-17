using KnightMove.Xadrez;
using Tabuleiro;

namespace KnightMove
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {

            
            Tabuleiro.Tabuleiro tabuleiro = new Tabuleiro.Tabuleiro(8, 8);

            tabuleiro.ColocarPeca(new Posicao(0, 0), new Torre(Cor.Branca, tabuleiro));
            tabuleiro.ColocarPeca(new Posicao(0, 3), new Torre(Cor.Branca, tabuleiro));
            tabuleiro.ColocarPeca(new Posicao(2, 2), new Torre(Cor.Branca, tabuleiro));

            Tela.ImprimirTabuleiro(tabuleiro);
            }
            catch (TabuleiroException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}