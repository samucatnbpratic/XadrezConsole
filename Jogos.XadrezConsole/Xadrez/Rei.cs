using Jogos.XadrezConsole.Tabuleiro;

namespace Jogos.XadrezConsole.Xadrez
{
    class Rei : Peca
    {
        public Rei(TabuleiroX tab, Cor cor): base(tab, cor)
        {

        }

        public override string ToString()
        {
            return "R";
        }
    }
}
