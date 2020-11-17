using Jogos.XadrezConsole.Tabuleiro;


namespace Jogos.XadrezConsole.Xadrez
{
    class Torre: Peca
    {
        public Torre(TabuleiroX tab, Cor cor) : base(tab, cor)
        {

        }

        public override string ToString()
        {
            return "T";
        }

    }
}
