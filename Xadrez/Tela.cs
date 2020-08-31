
using System;
using Xadrez.Tabuleiro;

namespace Xadrez
{
    class Tela
    {
        public static void imprimirTabuleiro(Tabuleiro tabuleiro) { 
            for(int i = 0; i < tabuleiro.linha; i++)
            {
                for(int j = 0; j <tabuleiro.coluna; j++){
                    Console.Write();
                }
            }
        }
    }
}
