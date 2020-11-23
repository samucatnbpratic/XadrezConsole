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
                /*
                PosicaoXadrez px = new PosicaoXadrez('b', 7);
                Console.WriteLine(px);

                Console.WriteLine(px.ToPosicao());
                */
                //TabuleiroX tab = new TabuleiroX(8, 8);

                PartidaDeXadrez px = new PartidaDeXadrez();
                Tela.ImprimirTabuleiro(px.Tab);
                
            }
            catch (TabuleiroException ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
