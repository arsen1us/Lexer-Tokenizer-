using Lexer;
using System.Text.RegularExpressions;

namespace ConsoleApp1.Tokenizer
{
    public class RegexTokenizer : ITokenizer
    {
        public List<TokenDefinition> TokenDefinitions;
        public RegexTokenizer()
        {
            #region TokenDefinitions
            TokenDefinitions = new List<TokenDefinition>
            {                
                new TokenDefinition(TokenType.T_add, new Regex(@"^add", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_and, new Regex(@"^and", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_alias, new Regex(@"^alias", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_ascending, new Regex(@"^ascending", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_args, new Regex(@"^args", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_async, new Regex(@"^async", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_await, new Regex(@"^await", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_by, new Regex(@"^by", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_descending, new Regex(@"^descending", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_dynamic, new Regex(@"^dynamic", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_equals, new Regex(@"^equals", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_from, new Regex(@"^from", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_get, new Regex(@"^get", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_global, new Regex(@"^global", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_group, new Regex(@"^group", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_init, new Regex(@"^init", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_into, new Regex(@"^into", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_join, new Regex(@"^join", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_let, new Regex(@"^let", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_managed, new Regex(@"^managed", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_nameof, new Regex(@"^nameof", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_nint, new Regex(@"^init", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_not, new Regex(@"^not", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_notnull, new Regex(@"^notnull", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_nuint, new Regex(@"^nuint", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_on, new Regex(@"^on", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_orderby, new Regex(@"^orderby", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_partial, new Regex(@"^partial", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_record, new Regex(@"^record", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_remove, new Regex(@"^remove", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_select, new Regex(@"^select", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_set, new Regex(@"^set", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_unmanaged, new Regex(@"^unmanaged", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_value, new Regex(@"^value", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_var, new Regex(@"^var", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_when, new Regex(@"^when", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_where, new Regex(@"^where", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_with, new Regex(@"^with", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_yield, new Regex(@"^yield", RegexOptions.IgnoreCase)),

                //Ключевые слова, которые нельзя использовать как идентификаторы в любой части программы C#

                new TokenDefinition(TokenType.T_Abstract, new Regex(@"^abstract", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_As, new Regex(@"^as", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_Base, new Regex(@"^base", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_Bool, new Regex(@"^bool", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_Break, new Regex(@"^break", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_Byte, new Regex(@"^byte", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_Case, new Regex(@"^case", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_Catch, new Regex(@"^catch", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_Char, new Regex(@"^char", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_Checked, new Regex(@"^checked", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_Class, new Regex(@"^class", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_Const, new Regex(@"^const", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_Continue, new Regex(@"^continue", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_Decimal, new Regex(@"^decimal", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_Default, new Regex(@"^default", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_Delegate, new Regex(@"^delegate", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_Do, new Regex(@"^do", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_Double, new Regex(@"^double", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_Else, new Regex(@"^else", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_Enum, new Regex(@"^enum", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_Event, new Regex(@"^event", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_Explicit, new Regex(@"^explicit", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_Extern, new Regex(@"^extern", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_False, new Regex(@"^false", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_Finally, new Regex(@"^finally", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_Fixed, new Regex(@"^fixed", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_Float, new Regex(@"^float", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_Foreach, new Regex(@"^foreach", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_For, new Regex(@"^for", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_Goto, new Regex(@"^goto", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_If, new Regex(@"^if", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_Implicit, new Regex(@"^inplicit", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_In, new Regex(@"^in", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_Int, new Regex(@"^int", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_Interface, new Regex(@"^interface", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_Internal, new Regex(@"^internal", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_Is, new Regex(@"^is", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_Lock, new Regex(@"^lock", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_Long, new Regex(@"^long", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_Namespace, new Regex(@"^namespace", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_New, new Regex(@"^new", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_Null, new Regex(@"^null", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_Object, new Regex(@"^object", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_Operator, new Regex(@"^operator", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_Out, new Regex(@"^out", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_Override, new Regex(@"^override", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_Params, new Regex(@"^params", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_Private, new Regex(@"^private", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_Protected, new Regex(@"^protected", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_Public, new Regex(@"^public", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_Readonly, new Regex(@"^readonly", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_Ref, new Regex(@"^ref", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_Return, new Regex(@"^return", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_Sbyte, new Regex(@"^sbyte", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_Sealed, new Regex(@"^sealed", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_Short, new Regex(@"^short", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_Sizeof, new Regex(@"^sizeof", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_Stackalloc, new Regex(@"^stackalloc", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_Static, new Regex(@"^static", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_String, new Regex(@"^string", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_Struct, new Regex(@"^struct", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_Switch, new Regex(@"^switch", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_This, new Regex(@"^this", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_Throw, new Regex(@"^throw", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_True, new Regex(@"^true", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_Try, new Regex(@"^try", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_Typeof, new Regex(@"^typeof", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_Uint, new Regex(@"^uint", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_Ulong, new Regex(@"^ulong", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_Unchecked, new Regex(@"^unchecked", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_Unsafe, new Regex(@"^unsafe", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_Ushort, new Regex(@"^ushort", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_Using, new Regex(@"^using", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_Virtual, new Regex(@"^virtual", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_Void, new Regex(@"^void", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_Volatile, new Regex(@"^volatile", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_While, new Regex(@"^while", RegexOptions.IgnoreCase)),

                new TokenDefinition(TokenType.T_Comment, new Regex(@"^//\S*//", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_SignMoreEquals, new Regex(@"^\>=", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_SignLessEquals, new Regex(@"^\<=", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_Increment, new Regex(@"^\+{2}", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_Plus, new Regex(@"^\+", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_Decrement, new Regex(@"^\-{2}", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_Minus, new Regex(@"^\-", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_Multiplication, new Regex(@"^\*", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_Division, new Regex(@"^\/", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_Persent, new Regex(@"^\%", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_SignMore, new Regex(@"^\>", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_SignLess, new Regex(@"^\<", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_Equals, new Regex(@"^\=", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_NoEqual, new Regex(@"^\!=", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_Appropriation, new Regex(@"^\==", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_OperatorAND, new Regex(@"^\&&", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_OperatorOR, new Regex(@"^\|+", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_ExclamationMark, new Regex(@"^\!", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_Semicolon, new Regex(@"^\;", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_Comma, new Regex(@"^\,", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_Dot, new Regex(@"^\.", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_OpenRoundBracket, new Regex(@"^\(", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_CloseRoundBracket, new Regex(@"^\)", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_OpenSquareBracket, new Regex(@"^\[", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_CloseSquareBracket, new Regex(@"^\]", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_OpenBrace, new Regex(@"^\{", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_CloseBrace, new Regex(@"^\}", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_Symbol, new Regex(@"[a-z]+", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_Number, new Regex(@"[0-9]+", RegexOptions.IgnoreCase)),
                new TokenDefinition(TokenType.T_Invalid, new Regex(@"\s+", RegexOptions.IgnoreCase)),
            };
            #endregion
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
        private string[] Splitter(string text)
        {
            return text.Split(" ");
        }
        




    }
}
