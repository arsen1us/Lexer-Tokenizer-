using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1.Tokenizer
{
    public class Token
    {
        private Regex _regex { get; }
        public TokenType TokenType { get; set; }
        
        public Token(Regex regex, TokenType tokenType)
        {
            _regex = regex;
            TokenType = tokenType;
        }
    }
}
