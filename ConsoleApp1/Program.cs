using ConsoleApp1.Tokenizer;
using Lexer.ReservedTokens;
using System.Text.RegularExpressions;


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

string expression = "foreach (var item in items) result++;";
string example = "1+2=3";

string assignment = "string str = asdf";
string[] words = expression.Split(" ");
foreach (var item in words)
{
    foreach (var i in regexTokenizer.Tokenize(item)) { Console.WriteLine($"Token Type: {i.TokenType} | Token Value: {i.Value}"); }
}

Console.WriteLine("TEST-2: ");
foreach (var item in Splitter(assignment))
{
    foreach (var i in regexTokenizer.Tokenize(item)) { Console.WriteLine($"Token Type: {i.TokenType} | Token Value: {i.Value}"); }
}


//foreach (var item in regexTokenizer.Tokenize(expression))
//{
//    Console.WriteLine($"Token type: {item.TokenType}\nToken Value: {item.Value}");
//}

//foreach (var item in regexRTTokenizer.Tokenize(expression.Replace(" ", "")))
//{
//    Console.WriteLine($"Token type: {item.TokenType}\nToken Value: {item.Value}");
//}


//string str1 = "and";
//string str2 = "add";
//string str3 = "alias";

//RegexRTTokenizer tokenizer = new RegexRTTokenizer();

//tokenizer.Tokenize(str1);
string[] Splitter(string text)
{
    return text.Split(" ");
}


