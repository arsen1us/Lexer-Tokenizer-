using Lexer;
using System.Text.RegularExpressions;

namespace ConsoleApp1.Tokenizer
{
    public class RegexTokenizer : ITokenizer
    {
        public List<TokenDefinition> TokenDefinitions;
        public RegexTokenizer()
        {
            TokenDefinitions = new List<TokenDefinition>
            {
                new TokenDefinition(new Regex(@"^//\S*//", RegexOptions.IgnoreCase), TokenType.T_Comment),
                new TokenDefinition(new Regex(@"^\>=", RegexOptions.IgnoreCase), TokenType.T_SignMoreEquals),
                new TokenDefinition(new Regex(@"^\<=", RegexOptions.IgnoreCase), TokenType.T_SignLessEquals),
                new TokenDefinition(new Regex(@"^\+{2}", RegexOptions.IgnoreCase), TokenType.T_Increment),
                new TokenDefinition(new Regex(@"^\+", RegexOptions.IgnoreCase), TokenType.T_Plus),
                new TokenDefinition(new Regex(@"^\-{2}", RegexOptions.IgnoreCase), TokenType.T_Decrement),
                new TokenDefinition(new Regex(@"^\-", RegexOptions.IgnoreCase), TokenType.T_Minus),
                new TokenDefinition(new Regex(@"^\*", RegexOptions.IgnoreCase), TokenType.T_Multiplication),
                new TokenDefinition(new Regex(@"^\/", RegexOptions.IgnoreCase), TokenType.T_Division),
                new TokenDefinition(new Regex(@"^\%", RegexOptions.IgnoreCase), TokenType.T_Persent),
                new TokenDefinition(new Regex(@"^\>", RegexOptions.IgnoreCase), TokenType.T_SignMore),
                new TokenDefinition(new Regex(@"^\<", RegexOptions.IgnoreCase), TokenType.T_SignLess),      
                new TokenDefinition(new Regex(@"^\=", RegexOptions.IgnoreCase), TokenType.T_Equals),
                new TokenDefinition(new Regex(@"^\!=", RegexOptions.IgnoreCase), TokenType.T_NoEqual),
                new TokenDefinition(new Regex(@"^\==", RegexOptions.IgnoreCase), TokenType.T_Appropriation),
                new TokenDefinition(new Regex(@"^\&&", RegexOptions.IgnoreCase), TokenType.T_OperatorAND),
                new TokenDefinition(new Regex(@"^\|+", RegexOptions.IgnoreCase), TokenType.T_OperatorOR),
                new TokenDefinition(new Regex(@"^\!", RegexOptions.IgnoreCase), TokenType.T_ExclamationMark),
                new TokenDefinition(new Regex(@"^\;", RegexOptions.IgnoreCase), TokenType.T_Semicolon),
                new TokenDefinition(new Regex(@"^\,", RegexOptions.IgnoreCase), TokenType.T_Comma),
                new TokenDefinition(new Regex(@"^\.", RegexOptions.IgnoreCase), TokenType.T_Dot),
                new TokenDefinition(new Regex(@"^\(", RegexOptions.IgnoreCase), TokenType.T_OpenRoundBracket),
                new TokenDefinition(new Regex(@"^\)", RegexOptions.IgnoreCase), TokenType.T_CloseRoundBracket),
                new TokenDefinition(new Regex(@"^\[", RegexOptions.IgnoreCase), TokenType.T_OpenSquareBracket),
                new TokenDefinition(new Regex(@"^\]", RegexOptions.IgnoreCase), TokenType.T_CloseSquareBracket),
                new TokenDefinition(new Regex(@"^\{", RegexOptions.IgnoreCase), TokenType.T_OpenBrace),
                new TokenDefinition(new Regex(@"^\}", RegexOptions.IgnoreCase), TokenType.T_CloseBrace),
                new TokenDefinition(new Regex(@"[a-z]+", RegexOptions.IgnoreCase), TokenType.T_Symbol),
                new TokenDefinition(new Regex(@"[0-9]+", RegexOptions.IgnoreCase), TokenType.T_Number),
            };
        }
        public List<TokenMatch> Tokenize(string text)
        {
            var tokens = new List<TokenMatch>();
            string remainingText = text;

            while(!string.IsNullOrWhiteSpace(remainingText))
            {
                var match = FindMatch(remainingText); // сразу находит T_Invalid

                if (match.IsMatch)
                {
                    tokens.Add(match);
                    remainingText = match.RemainingText;
                }
                else
                {
                    remainingText = remainingText.Substring(1, remainingText.Length - 1);
                }
                
            }
            return tokens;
        }

        private TokenMatch FindMatch(string text)
        {
            foreach (var tokenDefinition in TokenDefinitions)
            {
                if(IsWhiteSpace(text).TokenType == TokenType.T_Invalid)
                {
                    return IsWhiteSpace(text);
                }
                var match = tokenDefinition.Match(text); // проверяем, есть ли совпадение среди регулярных выражений;
                
                if (match.IsMatch)
                {
                    return match; // усли да, то возращаем объект TokenMatch;
                }
                
            }
            return new TokenMatch { IsMatch = false };
        }

        private TokenMatch IsWhiteSpace(string text)
        {
            var regex = new Regex(@"\s+");
            var match = regex.Match(text);
            if (match.Success)
            {
                return new TokenMatch
                {
                    IsMatch = false,
                    Value = match.Value,
                    RemainingText = string.Empty,
                    TokenType = TokenType.T_Invalid
                };
            }
            return new TokenMatch { IsMatch = false };
        }




    }
}
