using Jogos.XadrezConsole.Tabuleiro;
using Jogos.XadrezConsole.Xadrez;


namespace Jogos.XadrezConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            TabuleiroX tab = new TabuleiroX(8, 8);

            tab.ColocarPeca(new Torre(tab,Cor.Preta), new Posicao(0, 0));
            tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
            tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(2, 4));
            Tela.ImprimirTabuleiro(tab);
        }
    }
}
