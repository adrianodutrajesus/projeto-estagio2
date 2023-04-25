using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSISTENTE_E2.Grammatics
{
    internal abstract class GrammarBase
    {
        protected GrammarBase(string name, List<GrammarPoint> grammarPoints)
        {
            Name = name;
            GrammarPoints = grammarPoints;
        }

        public string Name { get; }
        public List<GrammarPoint> GrammarPoints { get; }
    }
}
