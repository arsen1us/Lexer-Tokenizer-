using ConsoleApp1.Tokenizer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lexer.Parser
{
    public class ParserTokenDefiintion
    {
        List<ParserToken> tokens;

        public ParserTokenDefiintion()
        {
            tokens = new List<ParserToken>();
            tokens.Add(new ParserToken(ParserTokenType.PT_Expression, new Regex(@"^T_NumberT_Equals""")));
            tokens.Add(new ParserToken(ParserTokenType.PT_Function, new Regex(@"^T_StaticT_Void")));

        }

        public void Match(List<TokenMatch>tokens)
        {
            string tokens_string = string.Empty;
            foreach(var token in tokens)
            {
                tokens_string += token.TokenType.ToString();
            }
            foreach(var parserTokenDefinition in this.tokens)
            {
                var match = parserTokenDefinition.regex.Match(tokens_string);
                if(match.Success)
                {
                    switch (parserTokenDefinition.ParserTokenType)
                    {
                        case ParserTokenType.PT_Expression:
                            {                      
                                Console.WriteLine($"\t\t\t{tokens[0].Value}\n\t\t{tokens[1].Value}\n\t{tokens[3].Value}\n{tokens[2].Value}\t{tokens[4].Value}");
                                break;
                            }
                        case ParserTokenType.PT_Function:
                            {
                                Console.WriteLine("It's a function");
                                break;
                            }
                    }
                    
                }
            }
        }
    }
}
