﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1.Tokenizer
{
    public class TokenDefinition
    {
        private Regex _regex { get; }
        private TokenType TokenType { get; }

        public TokenDefinition(Regex regex, TokenType tokenType)
        {
            _regex = regex;  
            TokenType = tokenType;
        }
        public TokenMatch Match(string inputString)
        {
            var match =_regex.Match(inputString);
            string value = string.Empty;
            if(match.Success)
            {
                value += match.Value;
                return new TokenMatch
                {
                    TokenType = TokenType,
                    Value = value,
                    IsMatch = true,
                    RemainingText = inputString.Substring(match.Length)                   
                };
            }
            return new TokenMatch
            {
                IsMatch = false
            };          
        }
        
    }
}
