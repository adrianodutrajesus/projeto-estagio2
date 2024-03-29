﻿using ASSISTENTE_E2.Grammatics.Grammars;

namespace ASSISTENTE_E2.Grammatics
{
    internal static class GrammarStructure
    {
        internal static GrammarBase GetGrammarByType(GrammarType grammarType)
        {
            switch (grammarType)
            {
                case GrammarType.System: return new GSystem(grammarType);
                case GrammarType.Time: return new GTime(grammarType);
                case GrammarType.Weather:
                default: return null;
            }
        }
    }
}
