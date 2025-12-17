using KnightMove.Xadrez;
using System;
using Tabuleiro;

namespace Xadrez
{
    internal class PartidaDeXadrez
    {
        public Tabuleiro.Tabuleiro Tab { get; private set; }
        private int Turno;
        private Cor JogadorAtual;
        public bool Terminada { get; private set; }

        public PartidaDeXadrez()
        {
            Tab = new Tabuleiro.Tabuleiro(8, 8);
            Turno = 1;
            JogadorAtual = Cor.Branca;
            Terminada = false;
            ColocarPecas();
        }

        public void ExecutaMovimento(Posicao origem, Posicao destino)
        {
            Peca p = Tab.RetirarPeca(origem);
            p.IncrementarQtdMovimentos();
            Peca pecaCapturada = Tab.RetirarPeca(destino);
            Tab.ColocarPeca(destino, p);
        }

        public void ColocarPecas()
        {
            Tab.ColocarPeca(new PosicaoXadrez('c', 1).ToPosicao(), new Torre(Cor.Branca, Tab));
            Tab.ColocarPeca(new PosicaoXadrez('c', 2).ToPosicao(), new Rei(Cor.Amarela, Tab));
            Tab.ColocarPeca(new PosicaoXadrez('c', 3).ToPosicao(), new Torre(Cor.Branca, Tab));
        }
    }
}
