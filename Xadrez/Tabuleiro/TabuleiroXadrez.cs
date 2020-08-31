using System;
using System.Collections.Generic;
using System.Text;
using Xadrez.Tabuleiro;

namespace Tabuleiro
{
    public class TabuleiroXadrez
    {
        public int linha { get; set; }
        public int coluna { get; set; }
        private Peca[,] pecas;

        public TabuleiroXadrez(int linha, int coluna)
        {
            this.linha = linha;
            this.coluna = coluna;
            pecas = new Peca[linha, coluna];
        }

        public Peca Peca(int linha, int coluna)
        {
            return pecas[linha, coluna];
        }
    }
}
