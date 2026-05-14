grammar DemangledNames;

function
    : functionPrefix functionReturnType callingConvention functionDeclaringScope functionName LeftParen functionParameters RightParen functionSuffix
    ;

callingConvention
    : CallingConvention?
    ;

functionPrefix
    : (AccessModifier Colon)? (Virtual | Static)?
    ;

functionSuffix
    : Const? (And | AndAnd)? (LeftParen Dot Number RightParen)?
    ;

functionReturnType
    : type?
    ;

functionDeclaringScope
    : (qualifiedTypeIdentifier Colon Colon)?
    ;

functionParameter
    : type (Const | Restrict)* (And | AndAnd | Star)*
    ;

functionParameters
    : functionParameter (Comma functionParameter)*
    |
    ;

templateParameter
    : LeftParen parenBoolExpr RightParen  // parenthesized condition: (sizeof(T) > 8ul)
    | boolTemplateExpr
    | Minus? Number
    | LeftParen type RightParen Minus? Number  // C-style cast: (unsigned char)0
    ;

// Used inside parens: allows bare > (no template-close ambiguity)
parenBoolExpr
    : parenAtomExpr ((AndAnd | PipePipe) parenAtomExpr)*
    ;

parenAtomExpr
    : Exclamation? simpleTemplateArg (relationalOperator simpleTemplateArg)?
    ;

boolTemplateExpr
    : templateAtomExpr ((AndAnd | PipePipe) templateAtomExpr)*
    ;

templateAtomExpr
    : Exclamation? simpleTemplateArg (templateRelationalOperator simpleTemplateArg)?
    ;

templateRelationalOperator
    : Less Equals?
    | Greater Equals  // >= only; bare > would conflict with template closing >
    | Equals Equals
    | Exclamation Equals
    ;

simpleTemplateArg
    : Sizeof LeftParen type RightParen
    | Minus? Number
    | type Const? (And | Star)*
    ;

template
    : Less templateParameter (Comma templateParameter)* Greater
    | Less Greater
    |
    ;

templateNotNull
    : Less templateParameter (Comma templateParameter)* Greater
    | Less Greater
    ;

functionName
    : functionIdentifier template (LeftBracket RightBracket)
    | functionIdentifier templateNotNull templateNotNull
    | functionIdentifier template
    ;

identifier
    : Identifier
    | EscapedString
    | SingleQuoteString
    | AccessModifier
    | Auto
    | CallingConvention
    | Complex
    | Double
    | NewOrDelete
    | TypeKeyword
    | Bool
    | Char
    | Const
    | Float
    | Int
    | Int64
    | Int128
    | Long
    | Operator
    | Restrict
    | Short
    | Signed
    | Static
    | Unsigned
    | Vector
    | Virtual
    | Void
    | AnonymousNamespace
    ;

functionIdentifier
    : operator
    | Tilde? identifier+
    | '_Static' SingleQuote SingleQuote
    ;

type
    : TypeKeyword? qualifiedTypeIdentifier Const? (Star | And | AndAnd)*
    | TypeKeyword? qualifiedTypeIdentifier Const? (Star | And | AndAnd)* Vector LeftBracket Number RightBracket (Const | Star | And)*  // SIMD vector: T vector[N]
    | type LeftParen Star Const RightParen LeftBracket Number RightBracket // constant array reference
    | type LeftParen And RightParen LeftBracket Number RightBracket // mutable array reference
    | type LeftBracket Number RightBracket // array type
    | type Vector LeftBracket Number RightBracket // recursive SIMD vector: cpp::array<T,N> vector[M]
    | type LeftParen CallingConvention? Star Const? RightParen LeftParen functionParameters RightParen // function pointer type
    | type LeftParen CallingConvention? And RightParen LeftParen functionParameters RightParen // function reference type
    ;

typeIdentifier
    : Void
    | Auto
    | DeclTypeAuto
    | numericType
    | AnonymousNamespace
    | identifier+ template
    | Less identifier+ Greater
    | Less identifier (Minus identifier)* Greater
    ;

qualifiedTypeIdentifier
    : qualifiedTypeIdentifier Colon Colon typeIdentifier
    | qualifiedTypeIdentifier Colon Colon SingleQuoteString LeftParen functionParameters RightParen  // lambda type scope: ::'lambda'(params)
    | qualifiedTypeIdentifier Colon Colon typeIdentifier LeftParen functionParameters RightParen     // function-call scope with optional template: ::funcname<T>(params)
    | typeIdentifier
    ;

numericType
    : Bool
    | Float Complex?
    | Double Complex?
    | Long Double Complex?
    | Unsigned integerType
    | Signed integerType
    | integerType
    ;

integerType
    : Char
    | Short
    | Int
    | Int64
    | Int128
    | Long Long
    | Long
    ;

operator
    : Operator operatorName
    ;

operatorName
    : NewOrDelete LeftBracket RightBracket
    | NewOrDelete
    | type  // conversion operators (handles operator T, operator T<T>, etc.)
    | shiftOperator Equals?
    | arithmeticOperator Equals?
    | logicalOperator Equals?
    | relationalOperator
    | Exclamation
    | Equals
    | Plus Plus
    | Minus Minus
    | Minus Greater Star  // ->* dereference
    | Minus Greater       // -> arrow operator
    | LeftBracket RightBracket
    | LeftParen RightParen
    | DoubleQuote DoubleQuote identifier  // user-defined literal: operator"" _suffix
    ;

arithmeticOperator
    : Plus
    | Minus
    | Star
    | Slash
    | Modulo
    ;

relationalOperator
    : Less Equals?
    | Greater Equals?
    | Equals Equals
    | Exclamation Equals
    ;

logicalOperator
    : AndAnd
    | And
    | PipePipe
    | Pipe
    | Caret
    | Tilde
    ;

shiftOperator
    : Less Less
    | Greater Greater
    ;

EscapedString
    : '`' ~[']* '\''
    ;

SingleQuoteString
    : '\'' ~[']+ '\''
    ;

AccessModifier
    : 'public'
    | 'protected'
    | 'private'
    ;

Auto
    : 'auto'
    ;

CallingConvention
    : '__cdecl'
    | '__clrcall'
    | '__stdcall'
    | '__fastcall'
    | '__thiscall'
    | '__vectorcall'
    ;

Complex
    : 'complex'
    | '_Complex'
    ;

NewOrDelete
    : 'new'
    | 'delete'
    ;

Sizeof
    : 'sizeof'
    ;

TypeKeyword
    : 'class'
    | 'struct'
    | 'union'
    | 'enum'
    ;

Bool
    : 'bool'
    ;

Char
    : 'char'
    ;

Const
    : 'const'
    ;

DeclTypeAuto
    : 'decltype(auto)'
    ;

Double
    : 'double'
    ;

Float
    : 'float'
    ;

Int
    : 'int'
    ;

Int64
    : '__int64'
    ;

Int128
    : '__int128'
    ;

Long
    : 'long'
    ;

Operator
    : 'operator'
    ;

Restrict
    : 'restrict'
    ;

Short
    : 'short'
    ;

Signed
    : 'signed'
    ;

Static
    : 'static'
    ;

Unsigned
    : 'unsigned'
    ;

Vector
    : 'vector'
    ;

Virtual
    : 'virtual'
    ;

Void
    : 'void'
    ;

AnonymousNamespace
    : '(anonymous namespace)'
    ;

AndAnd
    : '&&'
    ;

PipePipe
    : '||'
    ;

LeftParen
    : '('
    ;

RightParen
    : ')'
    ;

Less
    : '<'
    ;

Greater
    : '>'
    ;

Equals
    : '='
    ;

Plus
    : '+'
    ;

Minus
    : '-'
    ;

Star
    : '*'
    ;

Slash
    : '/'
    ;

Modulo
    : '%'
    ;

And
    : '&'
    ;

Pipe
    : '|'
    ;

Caret
    : '^'
    ;

Tilde
    : '~'
    ;

Exclamation
    : '!'
    ;

Colon
    : ':'
    ;

Comma
    : ','
    ;

Dot
    : '.'
    ;

BackTick
    : '`'
    ;

SingleQuote
    : '\''
    ;

DoubleQuote
    : '"'
    ;

LeftBrace
    : '{'
    ;

RightBrace
    : '}'
    ;

LeftBracket
    : '['
    ;

RightBracket
    : ']'
    ;

Identifier
    : IdentifierNondigit (IdentifierNondigit | Digit)*
    ;

Number
    : NonZeroDigit Digit* IntSuffix?
    | '0' HexNumber? IntSuffix?
    ;

fragment HexNumber
    : ('x' | 'X') HexadecimalDigit+
    ;

fragment IntSuffix
    : [uU] [lL]? [lL]?   // u, ul, ull
    | [lL] [lL]? [uU]?   // l, ll, lu, llu
    ;

fragment IdentifierNondigit
    : Nondigit
    | UniversalCharacterName
    //|   // other implementation-defined characters...
    ;

fragment Nondigit
    : [a-zA-Z_$]
    ;

fragment Digit
    : [0-9]
    ;

fragment NonZeroDigit
    : [1-9]
    ;

fragment UniversalCharacterName
    : '\\u' HexQuad
    | '\\U' HexQuad HexQuad
    ;

fragment HexQuad
    : HexadecimalDigit HexadecimalDigit HexadecimalDigit HexadecimalDigit
    ;

fragment HexadecimalDigit
    : [0-9a-fA-F]
    ;

Whitespace
    : [ \t]+ -> channel(HIDDEN)
    ;

Newline
    : ('\r' '\n'? | '\n') -> channel(HIDDEN)
    ;

