using KnightMove.Xadrez;
using System;
using Tabuleiro;

namespace Xadrez
{
    internal class PartidaDeXadrez
    {
        public Tabuleiro.Tabuleiro Tab { get; private set; }
        public int Turno { get; private set; }
        public Cor JogadorAtual { get; private set; }
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

        public void RealizaJogada(Posicao origem, Posicao destino)
        {
            ExecutaMovimento(origem, destino);
            Turno++;
            MudaJogador();
        }

        public void ValidarPosicaoDeOrigem(Posicao pos)
        {
            if(Tab.Peca(pos) == null)
            {
                throw new TabuleiroException("Não existe peça nessa posição!");
            }
            if(JogadorAtual != Tab.Peca(pos).Cor)
            {
                throw new TabuleiroException("A vez não é sua!");
            }
            if (!Tab.Peca(pos).ExistemMovimentosPossiveis())
            {
                throw new TabuleiroException("Não há movimentos possíveis para essa peça!");
            }
        }

        public void ValidarPosicaoDeDestino(Posicao origem, Posicao destino)
        {
            if (!Tab.Peca(origem).PodeMoverPara(destino))
            {
                throw new TabuleiroException("Posição de destino inválida!");
            }
        }

        public void MudaJogador()
        {
            if(JogadorAtual == Cor.Branca)
            {
                JogadorAtual = Cor.Preta;
            }
        }

        public void ColocarPecas()
        {
            Tab.ColocarPeca(new PosicaoXadrez('c', 1).ToPosicao(), new Torre(Cor.Branca, Tab));
            Tab.ColocarPeca(new PosicaoXadrez('c', 2).ToPosicao(), new Rei(Cor.Preta, Tab));
            Tab.ColocarPeca(new PosicaoXadrez('c', 3).ToPosicao(), new Torre(Cor.Branca, Tab));
            Tab.ColocarPeca(new PosicaoXadrez('c', 5).ToPosicao(), new Torre(Cor.Preta, Tab));
            Tab.ColocarPeca(new PosicaoXadrez('c', 6).ToPosicao(), new Rei(Cor.Preta, Tab));
            Tab.ColocarPeca(new PosicaoXadrez('c', 7).ToPosicao(), new Torre(Cor.Preta, Tab));
        }
    }
}
