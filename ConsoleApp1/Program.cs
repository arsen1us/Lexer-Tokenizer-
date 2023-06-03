using ConsoleApp1.Tokenizer;
using System.Text.RegularExpressions;
using Lexer.Parser;
using System.Linq.Expressions;
using System.Xml.Xsl;

#region ForLexerAndParser
string example_1 = "3 = 1 + 2";
string result = "";
var regexTokenizer = new RegexTokenizer();
List<TokenMatch> tokens = new List<TokenMatch>();

foreach (var item in Splitter(example_1))
{
    result += item;
}

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

string example_2 = "for(int i = 0; i < 10; i++) {}";
var result_Tokens = new List<TokenMatch>(); 
foreach(string item in Splitter(example_2))
{
    var this_result = regexTokenizer.Tokenize(item);
    foreach(TokenMatch token in this_result)
    result_Tokens.Add(token);
}
foreach (var item in result_Tokens) Console.WriteLine(item.Value);
//foreach (var item in regexTokenizer.Tokenize(example_2.Replace(" ", "")))
//{
//    Console.WriteLine($"Token type: {item.TokenType}\nToken value: {item.Value}");
//}

Parser parser = new Parser();

string example_3 = "a = 10 * 5 + 1";

var result_Tokens_2 = new List<TokenMatch>();

foreach (string item in Splitter(example_3))
{
    var this_result = regexTokenizer.Tokenize(item);
    foreach (TokenMatch token in this_result)
        result_Tokens_2.Add(token);
}

parser.Parse(result_Tokens_2);

string[] Splitter(string text)
{
    return text.Split(" ");
}







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

