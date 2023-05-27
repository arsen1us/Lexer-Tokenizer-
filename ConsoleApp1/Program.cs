using System.Text.RegularExpressions;
using ConsoleApp1.Tokenizer;
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

string str = "AAAa123!/%12><>=<1234====!=&&3||!;,.4()[]{}2";

string comment = "//aaa//";
var regexTokenizer = new RegexTokenizer();

foreach (var item in regexTokenizer.Tokenize(comment.Replace(" ", "")))
{
    Console.WriteLine($"Token type: {item.TokenType}\nToken Value: {item.Value}");
}

foreach (var item in regexTokenizer.Tokenize(str.Replace(" ", "")))
{
    Console.WriteLine($"Token type: {item.TokenType}\nToken Value: {item.Value}");
}








