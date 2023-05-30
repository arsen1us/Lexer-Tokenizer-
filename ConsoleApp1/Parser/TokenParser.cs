using ConsoleApp1.Tokenizer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexer.Parser
{
    public static class TokenParser
    {
        public static List<TokenMatch> Parse(List<TokenMatch> tokens)
        {
            for(int i = 0; i < tokens.Count; i++)
            {
                if (i + 1 == tokens.Count -1)
                {
                    tokens[i].Previous = tokens[i - 1];
                    tokens[i].Next = new TokenMatch { IsMatch = false };
                    break;
                }
                if(i - 1 == -1)
                {
                    tokens[i].Previous = new TokenMatch { IsMatch = false };    
                }
                else
                {
                    tokens[i].Next = tokens[i + 1];
                    tokens[i].Previous = tokens[i - 1];
                }
            }
            return tokens;
        }
    }
}
