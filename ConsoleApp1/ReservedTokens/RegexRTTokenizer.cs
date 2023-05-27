using ConsoleApp1.Tokenizer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace Lexer.ReservedTokens
{
    public class RegexRTTokenizer : ITokenizer
    {
        private List<TokenDefinition> tokens;

        public RegexRTTokenizer()
        {
            tokens = new List<TokenDefinition>
            {
                new TokenDefinition(ReservedTokenType.T_add, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_and, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_alias, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_ascending, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_args, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_async, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_await, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_by, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_descending, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_dynamic, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_equals, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_from, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_get, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_global, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_group, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_init, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_into, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_join, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_let, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_managed, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_nameof, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_nint, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_not, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_notnull, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_nuint, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_on, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_orderby, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_partial, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_record, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_remove, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_select, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_set, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_unmanaged, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_value, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_var, new Regex(@"^var", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_when, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_where, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_with, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_yield, new Regex(@"", RegexOptions.IgnoreCase)),

                //Ключевые слова, которые нельзя использовать как идентификаторы в любой части программы C#

                new TokenDefinition(ReservedTokenType.T_Abstract, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_As, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_Base, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_Bool, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_Break, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_Byte, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_Case, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_Catch, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_Char, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_Checked, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_Class, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_Const, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_Continue, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_Decimal, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_Default, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_Delegate, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_Do, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_Double, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_Else, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_Enum, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_Event, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_Explicit, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_Extern, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_False, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_Finally, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_Fixed, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_Float, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_For, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_Foreach, new Regex(@"^foreach", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_Goto, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_If, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_Implicit, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_In, new Regex(@"^in", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_Int, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_Interface, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_Internal, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_Is, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_Lock, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_Long, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_Namespace, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_New, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_Null, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_Object, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_Operator, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_Out, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_Override, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_Params, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_Private, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_Protected, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_Public, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_Readonly, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_Ref, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_Return, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_Sbyte, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_Sealed, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_Short, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_Sizeof, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_Stackalloc, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_Static, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_String, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_Struct, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_Switch, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_This, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_Throw, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_True, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_Try, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_Typeof, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_Uint, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_Ulong, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_Unchecked, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_Unsafe, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_Ushort, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_Using, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_Virtual, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_Void, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_Volatile, new Regex(@"", RegexOptions.IgnoreCase)),
                new TokenDefinition(ReservedTokenType.T_While, new Regex(@"", RegexOptions.IgnoreCase)),
            };
        }

        public List<TokenMatch> Tokenize(string text)
        {
            var tokens = new List<TokenMatch>();
            string remainingText = text;

            while (!string.IsNullOrWhiteSpace(remainingText))
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
            foreach (var tokenDefinition in tokens)
            {
                if (IsWhiteSpace(text).TokenType == TokenType.T_Invalid)
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
