using System;
using System.Collections.Generic;
using System.Text;

namespace Jogos.XadrezConsole.Tabuleiro
{
    class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; set; }
        public int QteMovimentos { get; set; }
        public TabuleiroX Tab { get; set; }

        public Peca(TabuleiroX tab, Cor cor)
        {
            this.Posicao = null;
            this.Tab = tab;
            this.Cor = cor;
            this.QteMovimentos = 0;
        }

  
    }
}
