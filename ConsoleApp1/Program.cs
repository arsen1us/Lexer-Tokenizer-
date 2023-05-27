using System.Text.RegularExpressions;
using ConsoleApp1.Tokenizer;
using Lexer.ReservedTokens;
using NUnit.Framework;


////Test();
////GC.Collect();
////Console.ReadLine();

//FinalizeObject fo = new FinalizeObject(1);
//fo.Dispose();
//Console.ReadLine();
//var fo1 = fo;
//Console.WriteLine(fo1.Id);

//using (FinalizeObject fo2 = new FinalizeObject(2))
//{
//    var jsstr = JsonSerializer.Serialize(fo2);
//    Console.WriteLine(jsstr);
//}
//void Test()
//{
//    Employee emp = new Employee();
//}


// сначала проверяет на зарезервированные токены, потом на обычные;

string str = "+++-AAAa123!/%12><>=<1234====!=&&3||!;,.4()[]{}2";

string comment = "//aaa//";

var regexTokenizer = new RegexTokenizer();

var regexRTTokenizer = new RegexRTTokenizer();




//foreach (var item in regexTokenizer.Tokenize(comment.Replace(" ", "")))
//{
//    Console.WriteLine($"Token type: {item.TokenType}\nToken Value: {item.Value}");
//}

//foreach (var item in regexTokenizer.Tokenize(str.Replace(" ", "")))
//{
//    Console.WriteLine($"Token type: {item.TokenType}\nToken Value: {item.Value}");
//}

Regex regex1 = new Regex(@"^foreach");
Console.WriteLine(regex1.Match("foreach"));

string expression = "foreach \n(var item in items) \n\tresult++;";

foreach (var item in regexTokenizer.Tokenize(expression.Replace(" ", "")))
{
    Console.WriteLine($"Token type: {item.TokenType}\nToken Value: {item.Value}");
}

//foreach (var item in regexRTTokenizer.Tokenize(expression.Replace(" ", "")))
//{
//    Console.WriteLine($"Token type: {item.TokenType}\nToken Value: {item.Value}");
//}




