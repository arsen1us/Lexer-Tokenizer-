using ConsoleApp1.Tokenizer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lexer.Parser
{
    public static class TokenParser
    {
        public static void Parse(List<TokenMatch> tokens)
        {
            Regex regexExample = new Regex(@"^T_NumberT_Equals");
            string result = "";
            foreach (var token in tokens)
            {
                result += token.TokenType.ToString();
            }
            
            var match = regexExample.Match(result);
            if (match.Success)
            {
                Console.WriteLine(
                    $"\t\t\t{tokens[0].Value}\n\t\t{tokens[1].Value}\n\t{tokens[3].Value}\n{tokens[2].Value}\t{tokens[4].Value}");
            }
        }

        

    }
}
