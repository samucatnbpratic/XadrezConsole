using System;
using System.Collections.Generic;
using System.Text;

namespace Jogos.XadrezConsole.Tabuleiro
{
    class TabuleiroException : Exception
    {
        public TabuleiroException(string msg) : base(msg) { }
    }
}
