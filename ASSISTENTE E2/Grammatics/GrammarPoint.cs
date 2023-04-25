using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSISTENTE_E2.Grammatics
{
    internal sealed class GrammarPoint
    {
        internal GrammarPoint(string[] inputs, GrammarSubType grammarSubType)
        {
            Inputs = inputs;
            GrammarSubType = grammarSubType;
        }

        internal string[] Inputs { get; }
        internal GrammarSubType GrammarSubType { get; }
    }
}
