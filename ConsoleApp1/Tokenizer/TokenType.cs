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
        T_CloseBrace, // }
        T_Invalid,
        T_Number,
        T_Symbol,
        T_Comment,
        T_Increment,
        T_Decrement,

        //Контекстные ключевые слова

        T_add,
        T_and,
        T_alias,
        T_ascending,
        T_args,
        T_async,
        T_await,
        T_by,
        T_descending,
        T_dynamic,
        T_equals,
        T_from,
        T_get,
        T_global,
        T_group,
        T_init,
        T_into,
        T_join,
        T_let,
        T_managed, //(соглашение о вызовах указателей функций)
        T_nameof,
        T_nint,
        T_not, //(не);
        T_notnull,
        T_nuint,
        T_on, //или диспетчер конфигурации служб
        T_orderby,
        T_partial, // (тип)
        T_record,
        T_remove,
        T_select,
        T_set,
        T_unmanaged, //(соглашение о вызовах указателей функций) (ограничение универсального типа)
        T_value,
        T_var,
        T_when, //(условие фильтра)
        T_where, //(ограничение универсального типа) (предложение запроса)
        T_with,
        T_yield,

        //Ключевые слова, которые нельзя использовать как идентификаторы в любой части программы C#

        T_Abstract,
        T_As,
        T_Base,
        T_Bool,
        T_Break,
        T_Byte,
        T_Case,
        T_Catch,
        T_Char,
        T_Checked,
        T_Class,
        T_Const,
        T_Continue,
        T_Decimal,
        T_Default,
        T_Delegate,
        T_Do,
        T_Double,
        T_Else,
        T_Enum,
        T_Event,
        T_Explicit,
        T_Extern,
        T_False,
        T_Finally,
        T_Fixed,
        T_Float,
        T_For,
        T_Foreach,
        T_Goto,
        T_If,
        T_Implicit,
        T_In,
        T_Int,
        T_Interface,
        T_Internal,
        T_Is,
        T_Lock,
        T_Long,
        T_Namespace,
        T_New,
        T_Null,
        T_Object,
        T_Operator,
        T_Out,
        T_Override,
        T_Params,
        T_Private,
        T_Protected,
        T_Public,
        T_Readonly,
        T_Ref,
        T_Return,
        T_Sbyte,
        T_Sealed,
        T_Short,
        T_Sizeof,
        T_Stackalloc,
        T_Static,
        T_String,
        T_Struct,
        T_Switch,
        T_This,
        T_Throw,
        T_True,
        T_Try,
        T_Typeof,
        T_Uint,
        T_Ulong,
        T_Unchecked,
        T_Unsafe,
        T_Ushort,
        T_Using,
        T_Virtual,
        T_Void,
        T_Volatile,
        T_While

    }
}
