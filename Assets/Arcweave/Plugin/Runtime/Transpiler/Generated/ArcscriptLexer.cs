//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.13.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from ArcscriptLexer.g4 by ANTLR 4.13.0

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Arcweave.Transpiler {
using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.13.0")]
[System.CLSCompliant(false)]
public partial class ArcscriptLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		CODESTART=1, NORMALTEXT=2, CODEEND=3, MENTION_TAG_OPEN=4, FLOAT=5, INTEGER=6, 
		DIGIT=7, LPAREN=8, RPAREN=9, ASSIGNMUL=10, ASSIGNDIV=11, ASSIGNADD=12, 
		ASSIGNSUB=13, MUL=14, DIV=15, ADD=16, SUB=17, GE=18, GT=19, LE=20, LT=21, 
		EQ=22, NE=23, AND=24, OR=25, ASSIGN=26, NEG=27, COMMA=28, LBRACE=29, RBRACE=30, 
		BOOLEAN=31, FNAME=32, VFNAME=33, VFNAMEVARS=34, IFKEYWORD=35, ELSEKEYWORD=36, 
		ELSEIFKEYWORD=37, ENDIFKEYWORD=38, ANDKEYWORD=39, ORKEYWORD=40, ISKEYWORD=41, 
		NOTKEYWORD=42, STRING=43, VARIABLE=44, WHITESPACE=45, TAG_CLOSE=46, ATTR_NAME=47, 
		TAG_EQUALS=48, MENTION_TAG_CLOSE=49, TAG_WHITESPACE=50, TAG_OPEN=51, MENTION_LABEL=52, 
		ATTR_VALUE=53, ATTRIBUTE=54;
	public const int
		CODESEGMENT=1, MENTIONSEGMENT=2, MENTIONLABELSEGMENT=3, MENTION_ATTR_SEGMENT=4;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE", "CODESEGMENT", "MENTIONSEGMENT", "MENTIONLABELSEGMENT", 
		"MENTION_ATTR_SEGMENT"
	};

	public static readonly string[] ruleNames = {
		"CODESTART", "NORMALTEXT", "CODEEND", "MENTION_TAG_OPEN", "FLOAT", "INTEGER", 
		"DIGIT", "LPAREN", "RPAREN", "ASSIGNMUL", "ASSIGNDIV", "ASSIGNADD", "ASSIGNSUB", 
		"MUL", "DIV", "ADD", "SUB", "GE", "GT", "LE", "LT", "EQ", "NE", "AND", 
		"OR", "ASSIGN", "NEG", "COMMA", "LBRACE", "RBRACE", "BOOLEAN", "FNAME", 
		"VFNAME", "VFNAMEVARS", "IFKEYWORD", "ELSEKEYWORD", "ELSEIFKEYWORD", "ENDIFKEYWORD", 
		"ANDKEYWORD", "ORKEYWORD", "ISKEYWORD", "NOTKEYWORD", "STRING", "STRING_CONTENT", 
		"VARIABLE", "WHITESPACE", "TAG_CLOSE", "ATTR_NAME", "TAG_EQUALS", "MENTION_TAG_CLOSE", 
		"TAG_WHITESPACE", "TAG_OPEN", "MENTION_LABEL", "ATTR_VALUE", "ATTRIBUTE", 
		"ATTCHARS", "ATTCHAR", "HEXCHARS", "DECCHARS", "DOUBLE_QUOTE_STRING", 
		"SINGLE_QUOTE_STRING"
	};


	public ArcscriptLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public ArcscriptLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, null, null, "'</code></pre>'", "'<span'", null, null, null, "'('", 
		"')'", "'*='", "'/='", "'+='", "'-='", "'*'", "'/'", "'+'", "'-'", null, 
		null, null, null, "'=='", "'!='", null, "'||'", null, "'!'", "','", "'{'", 
		"'}'", null, null, "'show'", null, "'if'", "'else'", "'elseif'", "'endif'", 
		"'and'", "'or'", "'is'", "'not'", null, null, null, "'>'", null, null, 
		"'/span>'", null, "'<'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "CODESTART", "NORMALTEXT", "CODEEND", "MENTION_TAG_OPEN", "FLOAT", 
		"INTEGER", "DIGIT", "LPAREN", "RPAREN", "ASSIGNMUL", "ASSIGNDIV", "ASSIGNADD", 
		"ASSIGNSUB", "MUL", "DIV", "ADD", "SUB", "GE", "GT", "LE", "LT", "EQ", 
		"NE", "AND", "OR", "ASSIGN", "NEG", "COMMA", "LBRACE", "RBRACE", "BOOLEAN", 
		"FNAME", "VFNAME", "VFNAMEVARS", "IFKEYWORD", "ELSEKEYWORD", "ELSEIFKEYWORD", 
		"ENDIFKEYWORD", "ANDKEYWORD", "ORKEYWORD", "ISKEYWORD", "NOTKEYWORD", 
		"STRING", "VARIABLE", "WHITESPACE", "TAG_CLOSE", "ATTR_NAME", "TAG_EQUALS", 
		"MENTION_TAG_CLOSE", "TAG_WHITESPACE", "TAG_OPEN", "MENTION_LABEL", "ATTR_VALUE", 
		"ATTRIBUTE"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "ArcscriptLexer.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override int[] SerializedAtn { get { return _serializedATN; } }

	static ArcscriptLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static int[] _serializedATN = {
		4,0,54,519,6,-1,6,-1,6,-1,6,-1,6,-1,2,0,7,0,2,1,7,1,2,2,7,2,2,3,7,3,2,
		4,7,4,2,5,7,5,2,6,7,6,2,7,7,7,2,8,7,8,2,9,7,9,2,10,7,10,2,11,7,11,2,12,
		7,12,2,13,7,13,2,14,7,14,2,15,7,15,2,16,7,16,2,17,7,17,2,18,7,18,2,19,
		7,19,2,20,7,20,2,21,7,21,2,22,7,22,2,23,7,23,2,24,7,24,2,25,7,25,2,26,
		7,26,2,27,7,27,2,28,7,28,2,29,7,29,2,30,7,30,2,31,7,31,2,32,7,32,2,33,
		7,33,2,34,7,34,2,35,7,35,2,36,7,36,2,37,7,37,2,38,7,38,2,39,7,39,2,40,
		7,40,2,41,7,41,2,42,7,42,2,43,7,43,2,44,7,44,2,45,7,45,2,46,7,46,2,47,
		7,47,2,48,7,48,2,49,7,49,2,50,7,50,2,51,7,51,2,52,7,52,2,53,7,53,2,54,
		7,54,2,55,7,55,2,56,7,56,2,57,7,57,2,58,7,58,2,59,7,59,2,60,7,60,1,0,1,
		0,1,0,1,0,1,0,1,0,5,0,134,8,0,10,0,12,0,137,9,0,1,0,1,0,1,0,1,0,1,0,1,
		0,1,0,1,0,5,0,147,8,0,10,0,12,0,150,9,0,1,0,1,0,1,0,1,0,1,1,4,1,157,8,
		1,11,1,12,1,158,1,2,1,2,1,2,1,2,1,2,1,2,1,2,1,2,1,2,1,2,1,2,1,2,1,2,1,
		2,1,2,1,2,1,3,1,3,1,3,1,3,1,3,1,3,1,3,1,3,1,4,5,4,186,8,4,10,4,12,4,189,
		9,4,1,4,1,4,4,4,193,8,4,11,4,12,4,194,1,5,4,5,198,8,5,11,5,12,5,199,1,
		6,1,6,1,7,1,7,1,8,1,8,1,9,1,9,1,9,1,10,1,10,1,10,1,11,1,11,1,11,1,12,1,
		12,1,12,1,13,1,13,1,14,1,14,1,15,1,15,1,16,1,16,1,17,1,17,1,17,1,18,1,
		18,1,18,1,18,1,18,3,18,236,8,18,1,19,1,19,1,19,1,20,1,20,1,20,1,20,1,20,
		3,20,246,8,20,1,21,1,21,1,21,1,22,1,22,1,22,1,23,1,23,1,23,1,23,1,23,1,
		23,1,23,1,23,1,23,1,23,1,23,1,23,3,23,266,8,23,1,24,1,24,1,24,1,25,1,25,
		1,26,1,26,1,27,1,27,1,28,1,28,1,29,1,29,1,30,1,30,1,30,1,30,1,30,1,30,
		1,30,1,30,1,30,3,30,290,8,30,1,31,1,31,1,31,1,31,1,31,1,31,1,31,1,31,1,
		31,1,31,1,31,1,31,1,31,1,31,1,31,1,31,1,31,1,31,1,31,1,31,1,31,1,31,1,
		31,1,31,1,31,1,31,1,31,1,31,1,31,1,31,1,31,1,31,1,31,1,31,1,31,1,31,1,
		31,3,31,329,8,31,1,32,1,32,1,32,1,32,1,32,1,33,1,33,1,33,1,33,1,33,1,33,
		1,33,1,33,1,33,1,33,1,33,1,33,1,33,3,33,349,8,33,1,34,1,34,1,34,1,35,1,
		35,1,35,1,35,1,35,1,36,1,36,1,36,1,36,1,36,1,36,1,36,1,37,1,37,1,37,1,
		37,1,37,1,37,1,38,1,38,1,38,1,38,1,39,1,39,1,39,1,40,1,40,1,40,1,41,1,
		41,1,41,1,41,1,42,1,42,5,42,388,8,42,10,42,12,42,391,9,42,1,42,1,42,1,
		42,5,42,396,8,42,10,42,12,42,399,9,42,1,42,3,42,402,8,42,1,43,1,43,1,43,
		3,43,407,8,43,1,44,1,44,5,44,411,8,44,10,44,12,44,414,9,44,1,45,4,45,417,
		8,45,11,45,12,45,418,1,45,1,45,1,46,1,46,1,46,1,46,1,47,1,47,5,47,429,
		8,47,10,47,12,47,432,9,47,1,48,1,48,1,48,1,48,1,49,1,49,1,49,1,49,1,49,
		1,49,1,49,1,49,1,49,1,50,1,50,1,50,1,50,1,51,1,51,1,51,1,51,1,52,4,52,
		456,8,52,11,52,12,52,457,1,53,5,53,461,8,53,10,53,12,53,464,9,53,1,53,
		1,53,1,53,1,53,1,54,1,54,1,54,1,54,1,54,3,54,475,8,54,1,55,4,55,478,8,
		55,11,55,12,55,479,1,55,3,55,483,8,55,1,56,3,56,486,8,56,1,57,1,57,4,57,
		490,8,57,11,57,12,57,491,1,58,4,58,495,8,58,11,58,12,58,496,1,58,3,58,
		500,8,58,1,59,1,59,5,59,504,8,59,10,59,12,59,507,9,59,1,59,1,59,1,60,1,
		60,5,60,513,8,60,10,60,12,60,516,9,60,1,60,1,60,1,158,0,61,5,1,7,2,9,3,
		11,4,13,5,15,6,17,7,19,8,21,9,23,10,25,11,27,12,29,13,31,14,33,15,35,16,
		37,17,39,18,41,19,43,20,45,21,47,22,49,23,51,24,53,25,55,26,57,27,59,28,
		61,29,63,30,65,31,67,32,69,33,71,34,73,35,75,36,77,37,79,38,81,39,83,40,
		85,41,87,42,89,43,91,0,93,44,95,45,97,46,99,47,101,48,103,49,105,50,107,
		51,109,52,111,53,113,54,115,0,117,0,119,0,121,0,123,0,125,0,5,0,1,2,3,
		4,14,1,0,62,62,1,0,48,57,5,0,10,10,13,13,34,34,39,39,92,92,9,0,34,34,39,
		39,92,92,97,98,102,102,110,110,114,114,116,116,118,118,4,0,36,36,65,90,
		95,95,97,122,5,0,36,36,48,57,65,90,95,95,97,122,3,0,9,10,13,13,32,32,3,
		0,58,58,65,90,97,122,5,0,45,46,48,58,65,90,95,95,97,122,1,0,60,60,7,0,
		35,35,43,59,61,61,63,63,65,90,95,95,97,122,3,0,48,57,65,70,97,102,2,0,
		34,34,60,60,2,0,39,39,60,60,546,0,5,1,0,0,0,0,7,1,0,0,0,1,9,1,0,0,0,1,
		11,1,0,0,0,1,13,1,0,0,0,1,15,1,0,0,0,1,17,1,0,0,0,1,19,1,0,0,0,1,21,1,
		0,0,0,1,23,1,0,0,0,1,25,1,0,0,0,1,27,1,0,0,0,1,29,1,0,0,0,1,31,1,0,0,0,
		1,33,1,0,0,0,1,35,1,0,0,0,1,37,1,0,0,0,1,39,1,0,0,0,1,41,1,0,0,0,1,43,
		1,0,0,0,1,45,1,0,0,0,1,47,1,0,0,0,1,49,1,0,0,0,1,51,1,0,0,0,1,53,1,0,0,
		0,1,55,1,0,0,0,1,57,1,0,0,0,1,59,1,0,0,0,1,61,1,0,0,0,1,63,1,0,0,0,1,65,
		1,0,0,0,1,67,1,0,0,0,1,69,1,0,0,0,1,71,1,0,0,0,1,73,1,0,0,0,1,75,1,0,0,
		0,1,77,1,0,0,0,1,79,1,0,0,0,1,81,1,0,0,0,1,83,1,0,0,0,1,85,1,0,0,0,1,87,
		1,0,0,0,1,89,1,0,0,0,1,93,1,0,0,0,1,95,1,0,0,0,2,97,1,0,0,0,2,99,1,0,0,
		0,2,101,1,0,0,0,2,103,1,0,0,0,2,105,1,0,0,0,3,107,1,0,0,0,3,109,1,0,0,
		0,4,111,1,0,0,0,4,113,1,0,0,0,5,127,1,0,0,0,7,156,1,0,0,0,9,160,1,0,0,
		0,11,176,1,0,0,0,13,187,1,0,0,0,15,197,1,0,0,0,17,201,1,0,0,0,19,203,1,
		0,0,0,21,205,1,0,0,0,23,207,1,0,0,0,25,210,1,0,0,0,27,213,1,0,0,0,29,216,
		1,0,0,0,31,219,1,0,0,0,33,221,1,0,0,0,35,223,1,0,0,0,37,225,1,0,0,0,39,
		227,1,0,0,0,41,235,1,0,0,0,43,237,1,0,0,0,45,245,1,0,0,0,47,247,1,0,0,
		0,49,250,1,0,0,0,51,265,1,0,0,0,53,267,1,0,0,0,55,270,1,0,0,0,57,272,1,
		0,0,0,59,274,1,0,0,0,61,276,1,0,0,0,63,278,1,0,0,0,65,289,1,0,0,0,67,328,
		1,0,0,0,69,330,1,0,0,0,71,348,1,0,0,0,73,350,1,0,0,0,75,353,1,0,0,0,77,
		358,1,0,0,0,79,365,1,0,0,0,81,371,1,0,0,0,83,375,1,0,0,0,85,378,1,0,0,
		0,87,381,1,0,0,0,89,401,1,0,0,0,91,406,1,0,0,0,93,408,1,0,0,0,95,416,1,
		0,0,0,97,422,1,0,0,0,99,426,1,0,0,0,101,433,1,0,0,0,103,437,1,0,0,0,105,
		446,1,0,0,0,107,450,1,0,0,0,109,455,1,0,0,0,111,462,1,0,0,0,113,474,1,
		0,0,0,115,477,1,0,0,0,117,485,1,0,0,0,119,487,1,0,0,0,121,494,1,0,0,0,
		123,501,1,0,0,0,125,510,1,0,0,0,127,128,5,60,0,0,128,129,5,112,0,0,129,
		130,5,114,0,0,130,131,5,101,0,0,131,135,1,0,0,0,132,134,8,0,0,0,133,132,
		1,0,0,0,134,137,1,0,0,0,135,133,1,0,0,0,135,136,1,0,0,0,136,138,1,0,0,
		0,137,135,1,0,0,0,138,139,5,62,0,0,139,140,5,60,0,0,140,141,5,99,0,0,141,
		142,5,111,0,0,142,143,5,100,0,0,143,144,5,101,0,0,144,148,1,0,0,0,145,
		147,8,0,0,0,146,145,1,0,0,0,147,150,1,0,0,0,148,146,1,0,0,0,148,149,1,
		0,0,0,149,151,1,0,0,0,150,148,1,0,0,0,151,152,5,62,0,0,152,153,1,0,0,0,
		153,154,6,0,0,0,154,6,1,0,0,0,155,157,9,0,0,0,156,155,1,0,0,0,157,158,
		1,0,0,0,158,159,1,0,0,0,158,156,1,0,0,0,159,8,1,0,0,0,160,161,5,60,0,0,
		161,162,5,47,0,0,162,163,5,99,0,0,163,164,5,111,0,0,164,165,5,100,0,0,
		165,166,5,101,0,0,166,167,5,62,0,0,167,168,5,60,0,0,168,169,5,47,0,0,169,
		170,5,112,0,0,170,171,5,114,0,0,171,172,5,101,0,0,172,173,5,62,0,0,173,
		174,1,0,0,0,174,175,6,2,1,0,175,10,1,0,0,0,176,177,5,60,0,0,177,178,5,
		115,0,0,178,179,5,112,0,0,179,180,5,97,0,0,180,181,5,110,0,0,181,182,1,
		0,0,0,182,183,6,3,2,0,183,12,1,0,0,0,184,186,3,17,6,0,185,184,1,0,0,0,
		186,189,1,0,0,0,187,185,1,0,0,0,187,188,1,0,0,0,188,190,1,0,0,0,189,187,
		1,0,0,0,190,192,5,46,0,0,191,193,3,17,6,0,192,191,1,0,0,0,193,194,1,0,
		0,0,194,192,1,0,0,0,194,195,1,0,0,0,195,14,1,0,0,0,196,198,3,17,6,0,197,
		196,1,0,0,0,198,199,1,0,0,0,199,197,1,0,0,0,199,200,1,0,0,0,200,16,1,0,
		0,0,201,202,7,1,0,0,202,18,1,0,0,0,203,204,5,40,0,0,204,20,1,0,0,0,205,
		206,5,41,0,0,206,22,1,0,0,0,207,208,5,42,0,0,208,209,5,61,0,0,209,24,1,
		0,0,0,210,211,5,47,0,0,211,212,5,61,0,0,212,26,1,0,0,0,213,214,5,43,0,
		0,214,215,5,61,0,0,215,28,1,0,0,0,216,217,5,45,0,0,217,218,5,61,0,0,218,
		30,1,0,0,0,219,220,5,42,0,0,220,32,1,0,0,0,221,222,5,47,0,0,222,34,1,0,
		0,0,223,224,5,43,0,0,224,36,1,0,0,0,225,226,5,45,0,0,226,38,1,0,0,0,227,
		228,3,41,18,0,228,229,5,61,0,0,229,40,1,0,0,0,230,236,5,62,0,0,231,232,
		5,38,0,0,232,233,5,103,0,0,233,234,5,116,0,0,234,236,5,59,0,0,235,230,
		1,0,0,0,235,231,1,0,0,0,236,42,1,0,0,0,237,238,3,45,20,0,238,239,5,61,
		0,0,239,44,1,0,0,0,240,246,5,60,0,0,241,242,5,38,0,0,242,243,5,108,0,0,
		243,244,5,116,0,0,244,246,5,59,0,0,245,240,1,0,0,0,245,241,1,0,0,0,246,
		46,1,0,0,0,247,248,5,61,0,0,248,249,5,61,0,0,249,48,1,0,0,0,250,251,5,
		33,0,0,251,252,5,61,0,0,252,50,1,0,0,0,253,254,5,38,0,0,254,266,5,38,0,
		0,255,256,5,38,0,0,256,257,5,97,0,0,257,258,5,109,0,0,258,259,5,112,0,
		0,259,260,5,59,0,0,260,261,5,38,0,0,261,262,5,97,0,0,262,263,5,109,0,0,
		263,264,5,112,0,0,264,266,5,59,0,0,265,253,1,0,0,0,265,255,1,0,0,0,266,
		52,1,0,0,0,267,268,5,124,0,0,268,269,5,124,0,0,269,54,1,0,0,0,270,271,
		5,61,0,0,271,56,1,0,0,0,272,273,5,33,0,0,273,58,1,0,0,0,274,275,5,44,0,
		0,275,60,1,0,0,0,276,277,5,123,0,0,277,62,1,0,0,0,278,279,5,125,0,0,279,
		64,1,0,0,0,280,281,5,116,0,0,281,282,5,114,0,0,282,283,5,117,0,0,283,290,
		5,101,0,0,284,285,5,102,0,0,285,286,5,97,0,0,286,287,5,108,0,0,287,288,
		5,115,0,0,288,290,5,101,0,0,289,280,1,0,0,0,289,284,1,0,0,0,290,66,1,0,
		0,0,291,292,5,97,0,0,292,293,5,98,0,0,293,329,5,115,0,0,294,295,5,109,
		0,0,295,296,5,97,0,0,296,329,5,120,0,0,297,298,5,109,0,0,298,299,5,105,
		0,0,299,329,5,110,0,0,300,301,5,114,0,0,301,302,5,97,0,0,302,303,5,110,
		0,0,303,304,5,100,0,0,304,305,5,111,0,0,305,329,5,109,0,0,306,307,5,114,
		0,0,307,308,5,111,0,0,308,309,5,108,0,0,309,329,5,108,0,0,310,311,5,114,
		0,0,311,312,5,111,0,0,312,313,5,117,0,0,313,314,5,110,0,0,314,329,5,100,
		0,0,315,316,5,115,0,0,316,317,5,113,0,0,317,329,5,114,0,0,318,319,5,115,
		0,0,319,320,5,113,0,0,320,321,5,114,0,0,321,329,5,116,0,0,322,323,5,118,
		0,0,323,324,5,105,0,0,324,325,5,115,0,0,325,326,5,105,0,0,326,327,5,116,
		0,0,327,329,5,115,0,0,328,291,1,0,0,0,328,294,1,0,0,0,328,297,1,0,0,0,
		328,300,1,0,0,0,328,306,1,0,0,0,328,310,1,0,0,0,328,315,1,0,0,0,328,318,
		1,0,0,0,328,322,1,0,0,0,329,68,1,0,0,0,330,331,5,115,0,0,331,332,5,104,
		0,0,332,333,5,111,0,0,333,334,5,119,0,0,334,70,1,0,0,0,335,336,5,114,0,
		0,336,337,5,101,0,0,337,338,5,115,0,0,338,339,5,101,0,0,339,349,5,116,
		0,0,340,341,5,114,0,0,341,342,5,101,0,0,342,343,5,115,0,0,343,344,5,101,
		0,0,344,345,5,116,0,0,345,346,5,65,0,0,346,347,5,108,0,0,347,349,5,108,
		0,0,348,335,1,0,0,0,348,340,1,0,0,0,349,72,1,0,0,0,350,351,5,105,0,0,351,
		352,5,102,0,0,352,74,1,0,0,0,353,354,5,101,0,0,354,355,5,108,0,0,355,356,
		5,115,0,0,356,357,5,101,0,0,357,76,1,0,0,0,358,359,5,101,0,0,359,360,5,
		108,0,0,360,361,5,115,0,0,361,362,5,101,0,0,362,363,5,105,0,0,363,364,
		5,102,0,0,364,78,1,0,0,0,365,366,5,101,0,0,366,367,5,110,0,0,367,368,5,
		100,0,0,368,369,5,105,0,0,369,370,5,102,0,0,370,80,1,0,0,0,371,372,5,97,
		0,0,372,373,5,110,0,0,373,374,5,100,0,0,374,82,1,0,0,0,375,376,5,111,0,
		0,376,377,5,114,0,0,377,84,1,0,0,0,378,379,5,105,0,0,379,380,5,115,0,0,
		380,86,1,0,0,0,381,382,5,110,0,0,382,383,5,111,0,0,383,384,5,116,0,0,384,
		88,1,0,0,0,385,389,5,34,0,0,386,388,3,91,43,0,387,386,1,0,0,0,388,391,
		1,0,0,0,389,387,1,0,0,0,389,390,1,0,0,0,390,392,1,0,0,0,391,389,1,0,0,
		0,392,402,5,34,0,0,393,397,5,39,0,0,394,396,3,91,43,0,395,394,1,0,0,0,
		396,399,1,0,0,0,397,395,1,0,0,0,397,398,1,0,0,0,398,400,1,0,0,0,399,397,
		1,0,0,0,400,402,5,39,0,0,401,385,1,0,0,0,401,393,1,0,0,0,402,90,1,0,0,
		0,403,407,8,2,0,0,404,405,5,92,0,0,405,407,7,3,0,0,406,403,1,0,0,0,406,
		404,1,0,0,0,407,92,1,0,0,0,408,412,7,4,0,0,409,411,7,5,0,0,410,409,1,0,
		0,0,411,414,1,0,0,0,412,410,1,0,0,0,412,413,1,0,0,0,413,94,1,0,0,0,414,
		412,1,0,0,0,415,417,7,6,0,0,416,415,1,0,0,0,417,418,1,0,0,0,418,416,1,
		0,0,0,418,419,1,0,0,0,419,420,1,0,0,0,420,421,6,45,3,0,421,96,1,0,0,0,
		422,423,5,62,0,0,423,424,1,0,0,0,424,425,6,46,4,0,425,98,1,0,0,0,426,430,
		7,7,0,0,427,429,7,8,0,0,428,427,1,0,0,0,429,432,1,0,0,0,430,428,1,0,0,
		0,430,431,1,0,0,0,431,100,1,0,0,0,432,430,1,0,0,0,433,434,5,61,0,0,434,
		435,1,0,0,0,435,436,6,48,5,0,436,102,1,0,0,0,437,438,5,47,0,0,438,439,
		5,115,0,0,439,440,5,112,0,0,440,441,5,97,0,0,441,442,5,110,0,0,442,443,
		5,62,0,0,443,444,1,0,0,0,444,445,6,49,1,0,445,104,1,0,0,0,446,447,7,6,
		0,0,447,448,1,0,0,0,448,449,6,50,3,0,449,106,1,0,0,0,450,451,5,60,0,0,
		451,452,1,0,0,0,452,453,6,51,1,0,453,108,1,0,0,0,454,456,8,9,0,0,455,454,
		1,0,0,0,456,457,1,0,0,0,457,455,1,0,0,0,457,458,1,0,0,0,458,110,1,0,0,
		0,459,461,5,32,0,0,460,459,1,0,0,0,461,464,1,0,0,0,462,460,1,0,0,0,462,
		463,1,0,0,0,463,465,1,0,0,0,464,462,1,0,0,0,465,466,3,113,54,0,466,467,
		1,0,0,0,467,468,6,53,1,0,468,112,1,0,0,0,469,475,3,123,59,0,470,475,3,
		125,60,0,471,475,3,115,55,0,472,475,3,119,57,0,473,475,3,121,58,0,474,
		469,1,0,0,0,474,470,1,0,0,0,474,471,1,0,0,0,474,472,1,0,0,0,474,473,1,
		0,0,0,475,114,1,0,0,0,476,478,3,117,56,0,477,476,1,0,0,0,478,479,1,0,0,
		0,479,477,1,0,0,0,479,480,1,0,0,0,480,482,1,0,0,0,481,483,5,32,0,0,482,
		481,1,0,0,0,482,483,1,0,0,0,483,116,1,0,0,0,484,486,7,10,0,0,485,484,1,
		0,0,0,486,118,1,0,0,0,487,489,5,35,0,0,488,490,7,11,0,0,489,488,1,0,0,
		0,490,491,1,0,0,0,491,489,1,0,0,0,491,492,1,0,0,0,492,120,1,0,0,0,493,
		495,7,1,0,0,494,493,1,0,0,0,495,496,1,0,0,0,496,494,1,0,0,0,496,497,1,
		0,0,0,497,499,1,0,0,0,498,500,5,37,0,0,499,498,1,0,0,0,499,500,1,0,0,0,
		500,122,1,0,0,0,501,505,5,34,0,0,502,504,8,12,0,0,503,502,1,0,0,0,504,
		507,1,0,0,0,505,503,1,0,0,0,505,506,1,0,0,0,506,508,1,0,0,0,507,505,1,
		0,0,0,508,509,5,34,0,0,509,124,1,0,0,0,510,514,5,39,0,0,511,513,8,13,0,
		0,512,511,1,0,0,0,513,516,1,0,0,0,514,512,1,0,0,0,514,515,1,0,0,0,515,
		517,1,0,0,0,516,514,1,0,0,0,517,518,5,39,0,0,518,126,1,0,0,0,35,0,1,2,
		3,4,135,148,158,187,194,199,235,245,265,289,328,348,389,397,401,406,412,
		418,430,457,462,474,479,482,485,491,496,499,505,514,6,5,1,0,4,0,0,5,2,
		0,6,0,0,5,3,0,5,4,0
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
} // namespace Arcweave.Transpiler
