using System;
using System.Collections.Generic;
using System.Text;
using Tabuleiro;

namespace Xadrez.Tabuleiro
{
    class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qtdadeMovimentos { get; protected set; }
        public TabuleiroXadrez tabuleiro { get; set; }

        public Peca(Posicao posicao, Cor cor, TabuleiroXadrez tabuleiro)
        {
            this.posicao = posicao;
            this.cor = cor;
            this.tabuleiro = tabuleiro;
            this.qtdadeMovimentos = 0;
        }
    }
}
