using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Tokenizer
{
    public enum TokenType
    {
        T_Plus,
        T_Minus,
        T_Multiplication,
        T_Division,
        T_Persent,
        T_SignMore, // >
        T_SignLess, // <
        T_SignMoreEquals, // >=
        T_SignLessEquals, // >=
        T_Equals,
        T_Appropriation, // ==
        T_NoEqual,
        T_OperatorAND,
        T_OperatorOR,
        T_ExclamationMark, // !
        T_Semicolon, // ;
        T_Comma, // ,
        T_Dot,
        T_OpenRoundBracket, // )
        T_CloseRoundBracket, // (
        T_OpenSquareBracket, // [
        T_CloseSquareBracket, // ]
        T_OpenBrace, // {
        T_CloseBrace,
        T_Invalid// }
           
    }
}
