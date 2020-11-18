﻿using Jogos.XadrezConsole.Tabuleiro;
using Jogos.XadrezConsole.Xadrez;
using System;

namespace Jogos.XadrezConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /*
                PosicaoXadrez px = new PosicaoXadrez('b', 7);
                Console.WriteLine(px);

                Console.WriteLine(px.ToPosicao());
                */
                TabuleiroX tab = new TabuleiroX(8, 8);


                tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
                tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(2, 4));
                tab.ColocarPeca(new Torre(tab, Cor.Branca), new Posicao(3, 5));
                Tela.ImprimirTabuleiro(tab);
                
            }
            catch (TabuleiroException ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
