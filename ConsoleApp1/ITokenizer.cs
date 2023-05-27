using ConsoleApp1.Tokenizer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexer
{
    interface ITokenizer
    {
        public List<TokenMatch> Tokenize(string text);

        //public TokenMatch FindMatch(string text);

        //public TokenMatch IsWhiteSpace(string text);
    }
}
