//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.7.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from Lang.g4 by ANTLR 4.7.2

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Grammar {
using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7.2")]
[System.CLSCompliant(false)]
public partial class LangLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, OE=3, CE=4, OB=5, CB=6, AT=7, SEP=8, PLUS=9, MINUS=10, 
		MULT=11, DIV=12, AND=13, OR=14, NOT=15, EQ=16, LT=17, GT=18, LE=19, GE=20, 
		NE=21, BOOL_TRUE=22, BOL_FALSE=23, IF=24, WHILE=25, DO=26, FOR=27, FUNCTION=28, 
		RETURN=29, THEN=30, ELSE=31, WRITE=32, READ=33, STR=34, EOL=35, NUM=36, 
		VAR=37, COMMENT=38, WS=39;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "OE", "CE", "OB", "CB", "AT", "SEP", "PLUS", "MINUS", 
		"MULT", "DIV", "AND", "OR", "NOT", "EQ", "LT", "GT", "LE", "GE", "NE", 
		"BOOL_TRUE", "BOL_FALSE", "IF", "WHILE", "DO", "FOR", "FUNCTION", "RETURN", 
		"THEN", "ELSE", "WRITE", "READ", "STR", "EOL", "NUM", "VAR", "COMMENT", 
		"WS"
	};


	public LangLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public LangLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, "'numero'", "'texto'", "'('", "')'", "'{'", "'}'", "'='", "','", 
		"'+'", "'-'", "'*'", "'/'", "'&&'", "'||'", "'!'", "'=='", "'<'", "'>'", 
		"'<='", "'>='", "'!='", "'true'", "'false'", null, null, null, null, null, 
		null, null, null, null, null, null, "';'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, "OE", "CE", "OB", "CB", "AT", "SEP", "PLUS", "MINUS", 
		"MULT", "DIV", "AND", "OR", "NOT", "EQ", "LT", "GT", "LE", "GE", "NE", 
		"BOOL_TRUE", "BOL_FALSE", "IF", "WHILE", "DO", "FOR", "FUNCTION", "RETURN", 
		"THEN", "ELSE", "WRITE", "READ", "STR", "EOL", "NUM", "VAR", "COMMENT", 
		"WS"
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

	public override string GrammarFileName { get { return "Lang.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static LangLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x2', ')', '\xFB', '\b', '\x1', '\x4', '\x2', '\t', '\x2', 
		'\x4', '\x3', '\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', 
		'\x5', '\x4', '\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', 
		'\t', '\b', '\x4', '\t', '\t', '\t', '\x4', '\n', '\t', '\n', '\x4', '\v', 
		'\t', '\v', '\x4', '\f', '\t', '\f', '\x4', '\r', '\t', '\r', '\x4', '\xE', 
		'\t', '\xE', '\x4', '\xF', '\t', '\xF', '\x4', '\x10', '\t', '\x10', '\x4', 
		'\x11', '\t', '\x11', '\x4', '\x12', '\t', '\x12', '\x4', '\x13', '\t', 
		'\x13', '\x4', '\x14', '\t', '\x14', '\x4', '\x15', '\t', '\x15', '\x4', 
		'\x16', '\t', '\x16', '\x4', '\x17', '\t', '\x17', '\x4', '\x18', '\t', 
		'\x18', '\x4', '\x19', '\t', '\x19', '\x4', '\x1A', '\t', '\x1A', '\x4', 
		'\x1B', '\t', '\x1B', '\x4', '\x1C', '\t', '\x1C', '\x4', '\x1D', '\t', 
		'\x1D', '\x4', '\x1E', '\t', '\x1E', '\x4', '\x1F', '\t', '\x1F', '\x4', 
		' ', '\t', ' ', '\x4', '!', '\t', '!', '\x4', '\"', '\t', '\"', '\x4', 
		'#', '\t', '#', '\x4', '$', '\t', '$', '\x4', '%', '\t', '%', '\x4', '&', 
		'\t', '&', '\x4', '\'', '\t', '\'', '\x4', '(', '\t', '(', '\x3', '\x2', 
		'\x3', '\x2', '\x3', '\x2', '\x3', '\x2', '\x3', '\x2', '\x3', '\x2', 
		'\x3', '\x2', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\x3', '\x3', '\x4', '\x3', '\x4', '\x3', '\x5', 
		'\x3', '\x5', '\x3', '\x6', '\x3', '\x6', '\x3', '\a', '\x3', '\a', '\x3', 
		'\b', '\x3', '\b', '\x3', '\t', '\x3', '\t', '\x3', '\n', '\x3', '\n', 
		'\x3', '\v', '\x3', '\v', '\x3', '\f', '\x3', '\f', '\x3', '\r', '\x3', 
		'\r', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xF', '\x3', '\xF', 
		'\x3', '\xF', '\x3', '\x10', '\x3', '\x10', '\x3', '\x11', '\x3', '\x11', 
		'\x3', '\x11', '\x3', '\x12', '\x3', '\x12', '\x3', '\x13', '\x3', '\x13', 
		'\x3', '\x14', '\x3', '\x14', '\x3', '\x14', '\x3', '\x15', '\x3', '\x15', 
		'\x3', '\x15', '\x3', '\x16', '\x3', '\x16', '\x3', '\x16', '\x3', '\x17', 
		'\x3', '\x17', '\x3', '\x17', '\x3', '\x17', '\x3', '\x17', '\x3', '\x18', 
		'\x3', '\x18', '\x3', '\x18', '\x3', '\x18', '\x3', '\x18', '\x3', '\x18', 
		'\x3', '\x19', '\x3', '\x19', '\x3', '\x19', '\x3', '\x1A', '\x3', '\x1A', 
		'\x3', '\x1A', '\x3', '\x1A', '\x3', '\x1A', '\x3', '\x1A', '\x3', '\x1B', 
		'\x3', '\x1B', '\x3', '\x1B', '\x3', '\x1C', '\x3', '\x1C', '\x3', '\x1C', 
		'\x3', '\x1C', '\x3', '\x1D', '\x3', '\x1D', '\x3', '\x1D', '\x3', '\x1D', 
		'\x3', '\x1D', '\x3', '\x1D', '\x3', '\x1D', '\x3', '\x1D', '\x3', '\x1D', 
		'\x3', '\x1E', '\x3', '\x1E', '\x3', '\x1E', '\x3', '\x1E', '\x3', '\x1E', 
		'\x3', '\x1E', '\x3', '\x1E', '\x3', '\x1F', '\x3', '\x1F', '\x3', '\x1F', 
		'\x3', '\x1F', '\x3', '\x1F', '\x3', ' ', '\x3', ' ', '\x3', ' ', '\x3', 
		' ', '\x3', ' ', '\x3', '!', '\x3', '!', '\x3', '!', '\x3', '!', '\x3', 
		'!', '\x3', '!', '\x3', '\"', '\x3', '\"', '\x3', '\"', '\x3', '\"', '\x3', 
		'\"', '\x3', '#', '\x3', '#', '\a', '#', '\xCD', '\n', '#', '\f', '#', 
		'\xE', '#', '\xD0', '\v', '#', '\x3', '#', '\x3', '#', '\x3', '$', '\x3', 
		'$', '\x3', '%', '\x6', '%', '\xD7', '\n', '%', '\r', '%', '\xE', '%', 
		'\xD8', '\x3', '%', '\x3', '%', '\x6', '%', '\xDD', '\n', '%', '\r', '%', 
		'\xE', '%', '\xDE', '\x5', '%', '\xE1', '\n', '%', '\x3', '&', '\x3', 
		'&', '\a', '&', '\xE5', '\n', '&', '\f', '&', '\xE', '&', '\xE8', '\v', 
		'&', '\x3', '\'', '\x3', '\'', '\x3', '\'', '\x3', '\'', '\a', '\'', '\xEE', 
		'\n', '\'', '\f', '\'', '\xE', '\'', '\xF1', '\v', '\'', '\x3', '\'', 
		'\x3', '\'', '\x3', '(', '\x6', '(', '\xF6', '\n', '(', '\r', '(', '\xE', 
		'(', '\xF7', '\x3', '(', '\x3', '(', '\x2', '\x2', ')', '\x3', '\x3', 
		'\x5', '\x4', '\a', '\x5', '\t', '\x6', '\v', '\a', '\r', '\b', '\xF', 
		'\t', '\x11', '\n', '\x13', '\v', '\x15', '\f', '\x17', '\r', '\x19', 
		'\xE', '\x1B', '\xF', '\x1D', '\x10', '\x1F', '\x11', '!', '\x12', '#', 
		'\x13', '%', '\x14', '\'', '\x15', ')', '\x16', '+', '\x17', '-', '\x18', 
		'/', '\x19', '\x31', '\x1A', '\x33', '\x1B', '\x35', '\x1C', '\x37', '\x1D', 
		'\x39', '\x1E', ';', '\x1F', '=', ' ', '?', '!', '\x41', '\"', '\x43', 
		'#', '\x45', '$', 'G', '%', 'I', '&', 'K', '\'', 'M', '(', 'O', ')', '\x3', 
		'\x2', '\x17', '\x4', '\x2', 'K', 'K', 'k', 'k', '\x4', '\x2', 'H', 'H', 
		'h', 'h', '\x4', '\x2', 'Y', 'Y', 'y', 'y', '\x4', '\x2', 'J', 'J', 'j', 
		'j', '\x4', '\x2', 'N', 'N', 'n', 'n', '\x4', '\x2', 'G', 'G', 'g', 'g', 
		'\x4', '\x2', '\x46', '\x46', '\x66', '\x66', '\x4', '\x2', 'Q', 'Q', 
		'q', 'q', '\x4', '\x2', 'T', 'T', 't', 't', '\x4', '\x2', 'W', 'W', 'w', 
		'w', '\x4', '\x2', 'P', 'P', 'p', 'p', '\x4', '\x2', '\x45', '\x45', '\x65', 
		'\x65', '\x4', '\x2', 'V', 'V', 'v', 'v', '\x4', '\x2', 'U', 'U', 'u', 
		'u', '\x4', '\x2', '\x43', '\x43', '\x63', '\x63', '\x3', '\x2', '$', 
		'$', '\x3', '\x2', '\x32', ';', '\x5', '\x2', '\x43', '\\', '\x61', '\x61', 
		'\x63', '|', '\x6', '\x2', '\x32', ';', '\x43', '\\', '\x61', '\x61', 
		'\x63', '|', '\x4', '\x2', '\f', '\f', '\xF', '\xF', '\x5', '\x2', '\v', 
		'\f', '\xF', '\xF', '\"', '\"', '\x2', '\x101', '\x2', '\x3', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\x5', '\x3', '\x2', '\x2', '\x2', '\x2', '\a', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\t', '\x3', '\x2', '\x2', '\x2', '\x2', '\v', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\r', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\xF', '\x3', '\x2', '\x2', '\x2', '\x2', '\x11', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x13', '\x3', '\x2', '\x2', '\x2', '\x2', '\x15', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x17', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x19', '\x3', '\x2', '\x2', '\x2', '\x2', '\x1B', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x1D', '\x3', '\x2', '\x2', '\x2', '\x2', '\x1F', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '!', '\x3', '\x2', '\x2', '\x2', '\x2', '#', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '%', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\'', '\x3', '\x2', '\x2', '\x2', '\x2', ')', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '+', '\x3', '\x2', '\x2', '\x2', '\x2', '-', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '/', '\x3', '\x2', '\x2', '\x2', '\x2', '\x31', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\x33', '\x3', '\x2', '\x2', '\x2', '\x2', '\x35', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\x37', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x39', '\x3', '\x2', '\x2', '\x2', '\x2', ';', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '=', '\x3', '\x2', '\x2', '\x2', '\x2', '?', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\x41', '\x3', '\x2', '\x2', '\x2', '\x2', '\x43', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\x45', '\x3', '\x2', '\x2', '\x2', 
		'\x2', 'G', '\x3', '\x2', '\x2', '\x2', '\x2', 'I', '\x3', '\x2', '\x2', 
		'\x2', '\x2', 'K', '\x3', '\x2', '\x2', '\x2', '\x2', 'M', '\x3', '\x2', 
		'\x2', '\x2', '\x2', 'O', '\x3', '\x2', '\x2', '\x2', '\x3', 'Q', '\x3', 
		'\x2', '\x2', '\x2', '\x5', 'X', '\x3', '\x2', '\x2', '\x2', '\a', '^', 
		'\x3', '\x2', '\x2', '\x2', '\t', '`', '\x3', '\x2', '\x2', '\x2', '\v', 
		'\x62', '\x3', '\x2', '\x2', '\x2', '\r', '\x64', '\x3', '\x2', '\x2', 
		'\x2', '\xF', '\x66', '\x3', '\x2', '\x2', '\x2', '\x11', 'h', '\x3', 
		'\x2', '\x2', '\x2', '\x13', 'j', '\x3', '\x2', '\x2', '\x2', '\x15', 
		'l', '\x3', '\x2', '\x2', '\x2', '\x17', 'n', '\x3', '\x2', '\x2', '\x2', 
		'\x19', 'p', '\x3', '\x2', '\x2', '\x2', '\x1B', 'r', '\x3', '\x2', '\x2', 
		'\x2', '\x1D', 'u', '\x3', '\x2', '\x2', '\x2', '\x1F', 'x', '\x3', '\x2', 
		'\x2', '\x2', '!', 'z', '\x3', '\x2', '\x2', '\x2', '#', '}', '\x3', '\x2', 
		'\x2', '\x2', '%', '\x7F', '\x3', '\x2', '\x2', '\x2', '\'', '\x81', '\x3', 
		'\x2', '\x2', '\x2', ')', '\x84', '\x3', '\x2', '\x2', '\x2', '+', '\x87', 
		'\x3', '\x2', '\x2', '\x2', '-', '\x8A', '\x3', '\x2', '\x2', '\x2', '/', 
		'\x8F', '\x3', '\x2', '\x2', '\x2', '\x31', '\x95', '\x3', '\x2', '\x2', 
		'\x2', '\x33', '\x98', '\x3', '\x2', '\x2', '\x2', '\x35', '\x9E', '\x3', 
		'\x2', '\x2', '\x2', '\x37', '\xA1', '\x3', '\x2', '\x2', '\x2', '\x39', 
		'\xA5', '\x3', '\x2', '\x2', '\x2', ';', '\xAE', '\x3', '\x2', '\x2', 
		'\x2', '=', '\xB5', '\x3', '\x2', '\x2', '\x2', '?', '\xBA', '\x3', '\x2', 
		'\x2', '\x2', '\x41', '\xBF', '\x3', '\x2', '\x2', '\x2', '\x43', '\xC5', 
		'\x3', '\x2', '\x2', '\x2', '\x45', '\xCA', '\x3', '\x2', '\x2', '\x2', 
		'G', '\xD3', '\x3', '\x2', '\x2', '\x2', 'I', '\xD6', '\x3', '\x2', '\x2', 
		'\x2', 'K', '\xE2', '\x3', '\x2', '\x2', '\x2', 'M', '\xE9', '\x3', '\x2', 
		'\x2', '\x2', 'O', '\xF5', '\x3', '\x2', '\x2', '\x2', 'Q', 'R', '\a', 
		'p', '\x2', '\x2', 'R', 'S', '\a', 'w', '\x2', '\x2', 'S', 'T', '\a', 
		'o', '\x2', '\x2', 'T', 'U', '\a', 'g', '\x2', '\x2', 'U', 'V', '\a', 
		't', '\x2', '\x2', 'V', 'W', '\a', 'q', '\x2', '\x2', 'W', '\x4', '\x3', 
		'\x2', '\x2', '\x2', 'X', 'Y', '\a', 'v', '\x2', '\x2', 'Y', 'Z', '\a', 
		'g', '\x2', '\x2', 'Z', '[', '\a', 'z', '\x2', '\x2', '[', '\\', '\a', 
		'v', '\x2', '\x2', '\\', ']', '\a', 'q', '\x2', '\x2', ']', '\x6', '\x3', 
		'\x2', '\x2', '\x2', '^', '_', '\a', '*', '\x2', '\x2', '_', '\b', '\x3', 
		'\x2', '\x2', '\x2', '`', '\x61', '\a', '+', '\x2', '\x2', '\x61', '\n', 
		'\x3', '\x2', '\x2', '\x2', '\x62', '\x63', '\a', '}', '\x2', '\x2', '\x63', 
		'\f', '\x3', '\x2', '\x2', '\x2', '\x64', '\x65', '\a', '\x7F', '\x2', 
		'\x2', '\x65', '\xE', '\x3', '\x2', '\x2', '\x2', '\x66', 'g', '\a', '?', 
		'\x2', '\x2', 'g', '\x10', '\x3', '\x2', '\x2', '\x2', 'h', 'i', '\a', 
		'.', '\x2', '\x2', 'i', '\x12', '\x3', '\x2', '\x2', '\x2', 'j', 'k', 
		'\a', '-', '\x2', '\x2', 'k', '\x14', '\x3', '\x2', '\x2', '\x2', 'l', 
		'm', '\a', '/', '\x2', '\x2', 'm', '\x16', '\x3', '\x2', '\x2', '\x2', 
		'n', 'o', '\a', ',', '\x2', '\x2', 'o', '\x18', '\x3', '\x2', '\x2', '\x2', 
		'p', 'q', '\a', '\x31', '\x2', '\x2', 'q', '\x1A', '\x3', '\x2', '\x2', 
		'\x2', 'r', 's', '\a', '(', '\x2', '\x2', 's', 't', '\a', '(', '\x2', 
		'\x2', 't', '\x1C', '\x3', '\x2', '\x2', '\x2', 'u', 'v', '\a', '~', '\x2', 
		'\x2', 'v', 'w', '\a', '~', '\x2', '\x2', 'w', '\x1E', '\x3', '\x2', '\x2', 
		'\x2', 'x', 'y', '\a', '#', '\x2', '\x2', 'y', ' ', '\x3', '\x2', '\x2', 
		'\x2', 'z', '{', '\a', '?', '\x2', '\x2', '{', '|', '\a', '?', '\x2', 
		'\x2', '|', '\"', '\x3', '\x2', '\x2', '\x2', '}', '~', '\a', '>', '\x2', 
		'\x2', '~', '$', '\x3', '\x2', '\x2', '\x2', '\x7F', '\x80', '\a', '@', 
		'\x2', '\x2', '\x80', '&', '\x3', '\x2', '\x2', '\x2', '\x81', '\x82', 
		'\a', '>', '\x2', '\x2', '\x82', '\x83', '\a', '?', '\x2', '\x2', '\x83', 
		'(', '\x3', '\x2', '\x2', '\x2', '\x84', '\x85', '\a', '@', '\x2', '\x2', 
		'\x85', '\x86', '\a', '?', '\x2', '\x2', '\x86', '*', '\x3', '\x2', '\x2', 
		'\x2', '\x87', '\x88', '\a', '#', '\x2', '\x2', '\x88', '\x89', '\a', 
		'?', '\x2', '\x2', '\x89', ',', '\x3', '\x2', '\x2', '\x2', '\x8A', '\x8B', 
		'\a', 'v', '\x2', '\x2', '\x8B', '\x8C', '\a', 't', '\x2', '\x2', '\x8C', 
		'\x8D', '\a', 'w', '\x2', '\x2', '\x8D', '\x8E', '\a', 'g', '\x2', '\x2', 
		'\x8E', '.', '\x3', '\x2', '\x2', '\x2', '\x8F', '\x90', '\a', 'h', '\x2', 
		'\x2', '\x90', '\x91', '\a', '\x63', '\x2', '\x2', '\x91', '\x92', '\a', 
		'n', '\x2', '\x2', '\x92', '\x93', '\a', 'u', '\x2', '\x2', '\x93', '\x94', 
		'\a', 'g', '\x2', '\x2', '\x94', '\x30', '\x3', '\x2', '\x2', '\x2', '\x95', 
		'\x96', '\t', '\x2', '\x2', '\x2', '\x96', '\x97', '\t', '\x3', '\x2', 
		'\x2', '\x97', '\x32', '\x3', '\x2', '\x2', '\x2', '\x98', '\x99', '\t', 
		'\x4', '\x2', '\x2', '\x99', '\x9A', '\t', '\x5', '\x2', '\x2', '\x9A', 
		'\x9B', '\t', '\x2', '\x2', '\x2', '\x9B', '\x9C', '\t', '\x6', '\x2', 
		'\x2', '\x9C', '\x9D', '\t', '\a', '\x2', '\x2', '\x9D', '\x34', '\x3', 
		'\x2', '\x2', '\x2', '\x9E', '\x9F', '\t', '\b', '\x2', '\x2', '\x9F', 
		'\xA0', '\t', '\t', '\x2', '\x2', '\xA0', '\x36', '\x3', '\x2', '\x2', 
		'\x2', '\xA1', '\xA2', '\t', '\x3', '\x2', '\x2', '\xA2', '\xA3', '\t', 
		'\t', '\x2', '\x2', '\xA3', '\xA4', '\t', '\n', '\x2', '\x2', '\xA4', 
		'\x38', '\x3', '\x2', '\x2', '\x2', '\xA5', '\xA6', '\t', '\x3', '\x2', 
		'\x2', '\xA6', '\xA7', '\t', '\v', '\x2', '\x2', '\xA7', '\xA8', '\t', 
		'\f', '\x2', '\x2', '\xA8', '\xA9', '\t', '\r', '\x2', '\x2', '\xA9', 
		'\xAA', '\t', '\xE', '\x2', '\x2', '\xAA', '\xAB', '\t', '\x2', '\x2', 
		'\x2', '\xAB', '\xAC', '\t', '\t', '\x2', '\x2', '\xAC', '\xAD', '\t', 
		'\f', '\x2', '\x2', '\xAD', ':', '\x3', '\x2', '\x2', '\x2', '\xAE', '\xAF', 
		'\t', '\n', '\x2', '\x2', '\xAF', '\xB0', '\t', '\a', '\x2', '\x2', '\xB0', 
		'\xB1', '\t', '\xE', '\x2', '\x2', '\xB1', '\xB2', '\t', '\v', '\x2', 
		'\x2', '\xB2', '\xB3', '\t', '\n', '\x2', '\x2', '\xB3', '\xB4', '\t', 
		'\f', '\x2', '\x2', '\xB4', '<', '\x3', '\x2', '\x2', '\x2', '\xB5', '\xB6', 
		'\t', '\xE', '\x2', '\x2', '\xB6', '\xB7', '\t', '\x5', '\x2', '\x2', 
		'\xB7', '\xB8', '\t', '\a', '\x2', '\x2', '\xB8', '\xB9', '\t', '\f', 
		'\x2', '\x2', '\xB9', '>', '\x3', '\x2', '\x2', '\x2', '\xBA', '\xBB', 
		'\t', '\a', '\x2', '\x2', '\xBB', '\xBC', '\t', '\x6', '\x2', '\x2', '\xBC', 
		'\xBD', '\t', '\xF', '\x2', '\x2', '\xBD', '\xBE', '\t', '\a', '\x2', 
		'\x2', '\xBE', '@', '\x3', '\x2', '\x2', '\x2', '\xBF', '\xC0', '\t', 
		'\x4', '\x2', '\x2', '\xC0', '\xC1', '\t', '\n', '\x2', '\x2', '\xC1', 
		'\xC2', '\t', '\x2', '\x2', '\x2', '\xC2', '\xC3', '\t', '\xE', '\x2', 
		'\x2', '\xC3', '\xC4', '\t', '\a', '\x2', '\x2', '\xC4', '\x42', '\x3', 
		'\x2', '\x2', '\x2', '\xC5', '\xC6', '\t', '\n', '\x2', '\x2', '\xC6', 
		'\xC7', '\t', '\a', '\x2', '\x2', '\xC7', '\xC8', '\t', '\x10', '\x2', 
		'\x2', '\xC8', '\xC9', '\t', '\b', '\x2', '\x2', '\xC9', '\x44', '\x3', 
		'\x2', '\x2', '\x2', '\xCA', '\xCE', '\a', '$', '\x2', '\x2', '\xCB', 
		'\xCD', '\n', '\x11', '\x2', '\x2', '\xCC', '\xCB', '\x3', '\x2', '\x2', 
		'\x2', '\xCD', '\xD0', '\x3', '\x2', '\x2', '\x2', '\xCE', '\xCC', '\x3', 
		'\x2', '\x2', '\x2', '\xCE', '\xCF', '\x3', '\x2', '\x2', '\x2', '\xCF', 
		'\xD1', '\x3', '\x2', '\x2', '\x2', '\xD0', '\xCE', '\x3', '\x2', '\x2', 
		'\x2', '\xD1', '\xD2', '\a', '$', '\x2', '\x2', '\xD2', '\x46', '\x3', 
		'\x2', '\x2', '\x2', '\xD3', '\xD4', '\a', '=', '\x2', '\x2', '\xD4', 
		'H', '\x3', '\x2', '\x2', '\x2', '\xD5', '\xD7', '\t', '\x12', '\x2', 
		'\x2', '\xD6', '\xD5', '\x3', '\x2', '\x2', '\x2', '\xD7', '\xD8', '\x3', 
		'\x2', '\x2', '\x2', '\xD8', '\xD6', '\x3', '\x2', '\x2', '\x2', '\xD8', 
		'\xD9', '\x3', '\x2', '\x2', '\x2', '\xD9', '\xE0', '\x3', '\x2', '\x2', 
		'\x2', '\xDA', '\xDC', '\v', '\x2', '\x2', '\x2', '\xDB', '\xDD', '\t', 
		'\x12', '\x2', '\x2', '\xDC', '\xDB', '\x3', '\x2', '\x2', '\x2', '\xDD', 
		'\xDE', '\x3', '\x2', '\x2', '\x2', '\xDE', '\xDC', '\x3', '\x2', '\x2', 
		'\x2', '\xDE', '\xDF', '\x3', '\x2', '\x2', '\x2', '\xDF', '\xE1', '\x3', 
		'\x2', '\x2', '\x2', '\xE0', '\xDA', '\x3', '\x2', '\x2', '\x2', '\xE0', 
		'\xE1', '\x3', '\x2', '\x2', '\x2', '\xE1', 'J', '\x3', '\x2', '\x2', 
		'\x2', '\xE2', '\xE6', '\t', '\x13', '\x2', '\x2', '\xE3', '\xE5', '\t', 
		'\x14', '\x2', '\x2', '\xE4', '\xE3', '\x3', '\x2', '\x2', '\x2', '\xE5', 
		'\xE8', '\x3', '\x2', '\x2', '\x2', '\xE6', '\xE4', '\x3', '\x2', '\x2', 
		'\x2', '\xE6', '\xE7', '\x3', '\x2', '\x2', '\x2', '\xE7', 'L', '\x3', 
		'\x2', '\x2', '\x2', '\xE8', '\xE6', '\x3', '\x2', '\x2', '\x2', '\xE9', 
		'\xEA', '\a', '\x31', '\x2', '\x2', '\xEA', '\xEB', '\a', '\x31', '\x2', 
		'\x2', '\xEB', '\xEF', '\x3', '\x2', '\x2', '\x2', '\xEC', '\xEE', '\n', 
		'\x15', '\x2', '\x2', '\xED', '\xEC', '\x3', '\x2', '\x2', '\x2', '\xEE', 
		'\xF1', '\x3', '\x2', '\x2', '\x2', '\xEF', '\xED', '\x3', '\x2', '\x2', 
		'\x2', '\xEF', '\xF0', '\x3', '\x2', '\x2', '\x2', '\xF0', '\xF2', '\x3', 
		'\x2', '\x2', '\x2', '\xF1', '\xEF', '\x3', '\x2', '\x2', '\x2', '\xF2', 
		'\xF3', '\b', '\'', '\x2', '\x2', '\xF3', 'N', '\x3', '\x2', '\x2', '\x2', 
		'\xF4', '\xF6', '\t', '\x16', '\x2', '\x2', '\xF5', '\xF4', '\x3', '\x2', 
		'\x2', '\x2', '\xF6', '\xF7', '\x3', '\x2', '\x2', '\x2', '\xF7', '\xF5', 
		'\x3', '\x2', '\x2', '\x2', '\xF7', '\xF8', '\x3', '\x2', '\x2', '\x2', 
		'\xF8', '\xF9', '\x3', '\x2', '\x2', '\x2', '\xF9', '\xFA', '\b', '(', 
		'\x2', '\x2', '\xFA', 'P', '\x3', '\x2', '\x2', '\x2', '\n', '\x2', '\xCE', 
		'\xD8', '\xDE', '\xE0', '\xE6', '\xEF', '\xF7', '\x3', '\b', '\x2', '\x2',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
} // namespace Grammar