using ConsoleApp1.Tokenizer;
using System.Text.RegularExpressions;

public class TokenDefinition
{
    private ReservedTokenType TokenType { get; }
    private Regex _regex { get; }

    public TokenDefinition(ReservedTokenType tokenType, Regex regex)
    {
        TokenType = tokenType;
        _regex = regex;
    }

    public TokenMatch Match(string text)
    {
        throw new Exception();
    }
}
