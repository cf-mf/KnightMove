using Tabuleiro;

namespace KnightMove
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro.Tabuleiro tabuleiro = new Tabuleiro.Tabuleiro(8, 8);

            Tela.ImprimirTabuleiro(tabuleiro);

            Console.WriteLine();
        }
    }
}