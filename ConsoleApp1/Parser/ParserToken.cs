using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lexer.Parser
{
    public class ParserToken
    {
        public Regex regex { get; set; }
        public ParserTokenType ParserTokenType { get; set; }

        public ParserToken(ParserTokenType parserTokenType, Regex regex)
        {
            this.ParserTokenType = parserTokenType;
            this.regex = regex;
        }
    }
}
