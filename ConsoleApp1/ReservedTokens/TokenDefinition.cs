using ConsoleApp1.Tokenizer;
using System.Text.RegularExpressions;

public class TokenDefinition
{
    private TokenType TokenType { get; }
    private Regex _regex { get; }

    public TokenDefinition(TokenType tokenType, Regex regex)
    {
        TokenType = tokenType;
        _regex = regex;
    }

    public TokenMatch Match(string text)
    {
        var match = _regex.Match(text);

        if(match.Success)
        {
            if(match.Value != string.Empty)
            {
                return new TokenMatch
                {

                };
            }
        }
        return new TokenMatch();
    }
}
