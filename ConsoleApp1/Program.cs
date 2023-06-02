using ConsoleApp1.Tokenizer;
using System.Text.RegularExpressions;
using Lexer.Parser;
using System.Linq.Expressions;

#region ForLexerAndParser
string example_1 = "3 = 1 + 2";
string result = "";
var regexTokenizer = new RegexTokenizer();
foreach (var item in Splitter(example_1))
{
    result += item;
}

List<TokenMatch> tokens = new List<TokenMatch>();
foreach (var item in regexTokenizer.Tokenize(result))
{
    Console.WriteLine($"Token type: {item.TokenType}\nToken value: {item.Value}");
}
foreach (var item in regexTokenizer.Tokenize(result))
{
    tokens.Add(item);
}
Console.WriteLine("Parsed Tokens: ");
TokenParser.Parse(tokens);

string[] Splitter(string text)
{
    return text.Split(" ");
}

string example_2 = "static void Main()" +
    "{" +
        "Console.WriteLine(Hello World!);" +
    "}";

string result_2 = string.Empty;
foreach (var item in Splitter(example_2))
{
    result_2 += item;
}
foreach (var item in regexTokenizer.Tokenize(result_2))
{
    Console.WriteLine($"Token type: {item.TokenType}\nToken value: {item.Value}");
}

var parser = new ParserTokenDefiintion();
Console.WriteLine("Expression test: ");
parser.Match(regexTokenizer.Tokenize(result));
Console.WriteLine("Function test: ");
parser.Match(regexTokenizer.Tokenize(result_2));


#endregion

//Creating Noge

Expression<Func<int>> sum = () => 1 + 2;

// Чтобы создать такое дерево, сначала надо
// создать конечные узлы
// конечные узлы являются константами

var one = Expression.Constant(1, typeof(int));
var two = Expression.Constant(2, typeof(int));

// Создание выражения сложения

var additing = Expression.Add(one, two);

// Создание лямбда-выражения

var lambda = Expression.Lambda(additing);

