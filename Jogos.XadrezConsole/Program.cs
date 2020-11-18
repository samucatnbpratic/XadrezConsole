using Jogos.XadrezConsole.Tabuleiro;
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

                TabuleiroX tab = new TabuleiroX(8, 8);

                tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
                tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(2, 4));
                tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 0));
                Tela.ImprimirTabuleiro(tab);
            }
            catch (TabuleiroException ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
