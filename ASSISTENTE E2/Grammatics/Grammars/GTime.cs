using System.Collections.Generic;

namespace ASSISTENTE_E2.Grammatics.Grammars
{
    internal sealed class GTime : GrammarBase
    {
        internal GTime(GrammarType grammarType)
      : base(grammarType.ToString(), GetGrammarPoints()) { }

        private static List<GrammarPoint> GetGrammarPoints() => new List<GrammarPoint>()
        {
           GetWhatTimeIsGrammarPoint(),
           GetWhatDateIsGrammarPoint(),
           GetWhatDayIsGrammarPoint(),
           GetWhatDayOfWeekIsGrammarPoint(),
        };

        private static GrammarPoint GetWhatTimeIsGrammarPoint()
        {
            var inputs = new string[]
            {
                "Que horas são",
                "Quais são as horas",
                "Que horas é",
                
            };

            return new GrammarPoint(inputs, GrammarSubType.WhatHourIs);
        }

        private static GrammarPoint GetWhatDateIsGrammarPoint()
        {
            var inputs = new string[]
            {
                "Que data é hoje",
                "Qual é a data de hoje",
                "Qual é a data",

            };

            return new GrammarPoint(inputs, GrammarSubType.WhatDateIs);
        }

        private static GrammarPoint GetWhatDayIsGrammarPoint()
        {
            var inputs = new string[]
            {
                "Que dia é hoje",
                "Qual o dia de hoje",
                "Qual que é o dia de hoje",

            };

            return new GrammarPoint(inputs, GrammarSubType.WhatDayIs);
        }

        private static GrammarPoint GetWhatDayOfWeekIsGrammarPoint()
        {
            var inputs = new string[]
            {
                "Que dia da semana",
                "Qual dia da semana",
                "Qual é o dia da semana de hoje",

            };

            return new GrammarPoint(inputs, GrammarSubType.WhatDayOfWeekIs);
        }
    }
}
