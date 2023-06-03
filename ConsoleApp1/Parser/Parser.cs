using ConsoleApp1.Tokenizer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lexer.Parser
{
    public class Parser
    {
        private List<TokenDefinition> _priority { get; set; }

        public Parser()
        {
            _priority = new List<TokenDefinition>
            {
                // HIGHT PRIORITY;
                new TokenDefinition(TokenType.T_Symbol, new Regex(@"[a-z]+", RegexOptions.IgnoreCase)), // symbol or word
                new TokenDefinition(TokenType.T_OperationPlus, new Regex(@"^\+", RegexOptions.IgnoreCase)), // +
                new TokenDefinition(TokenType.T_OperationMinus, new Regex(@"^\-", RegexOptions.IgnoreCase)), // -
                new TokenDefinition(TokenType.T_OperationMultiplication, new Regex(@"^\*", RegexOptions.IgnoreCase)), //*
                new TokenDefinition(TokenType.T_OperationDivision, new Regex(@"^\/", RegexOptions.IgnoreCase)), // /                                                                                                                              
                new TokenDefinition(TokenType.T_OperationPersent, new Regex(@"^\%", RegexOptions.IgnoreCase)), // %
                new TokenDefinition(TokenType.T_Number, new Regex(@"[0-9]+", RegexOptions.IgnoreCase)) // number

                // LOW PRIORITY;
                //new TokenDefinition(TokenType.T_Increment, new Regex(@"^T_Increment", RegexOptions.IgnoreCase)), // ++
                //new TokenDefinition(TokenType.T_Decrement, new Regex(@"^T_Decrement", RegexOptions.IgnoreCase)), // --
                //new TokenDefinition(TokenType.T_OperationPlus, new Regex(@"^T_OperationPlus", RegexOptions.IgnoreCase)), // +
                //new TokenDefinition(TokenType.T_OperationMinus, new Regex(@"^T_OperationMinus", RegexOptions.IgnoreCase)), // -
                //new TokenDefinition(TokenType.T_SignMoreEquals, new Regex(@"^T_SignMoreEquals", RegexOptions.IgnoreCase)), // >=         
                //new TokenDefinition(TokenType.T_SignLessEquals, new Regex(@"^T_SignLessEquals", RegexOptions.IgnoreCase)), // <=
                //new TokenDefinition(TokenType.T_Equals, new Regex(@"^\=", RegexOptions.IgnoreCase)), // =
                //new TokenDefinition(TokenType.T_SignMore, new Regex(@"^T_SignMore", RegexOptions.IgnoreCase)), // >                
                //new TokenDefinition(TokenType.T_SignLess, new Regex(@"^T_SignLess", RegexOptions.IgnoreCase)) // <                     
                                
            };

        }
        public void Parse(List<TokenMatch> tokens)
        {
            //for(int i = 0; i < tokens.Count; i++)
            //{
            //    foreach(TokenDefinition tokenDefinition in _priority)
            //    {
            //        if (tokens[i].TokenType == tokenDefinition.TokenType)
            //        {
            //            Console.WriteLine($"Value: {tokens[i].Value} Token type: {tokens[i].TokenType}");
            //        }
            //    }
            //}
            string result_string = string.Empty;
            foreach (var item in tokens)
            {
                result_string += item.Value;
            }
            result_string = result_string.Replace("=", "");
            while (result_string != null)
            {
                foreach (TokenDefinition tokenDefinition in _priority)
                {
                    var match = tokenDefinition._regex.Match(result_string);
                    if (match.Success)
                    {
                        Console.WriteLine(tokenDefinition.TokenType);
                        Console.WriteLine(match.Value);
                        result_string = result_string.Replace(match.Value, "");
                    }
                }
            }
        }
    }
}
