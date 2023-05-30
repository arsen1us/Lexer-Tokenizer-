using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Tokenizer
{
    public class TokenMatch
    {
        public bool IsMatch { get; set; }
        public TokenType TokenType { get; set; }
        public string Value { get; set; } = string.Empty;
        public string RemainingText { get; set; }
        public int Position { get; set; }

        public TokenMatch Next { get; set; } = null;
        public TokenMatch Previous { get; set; } = null;
    }
}
