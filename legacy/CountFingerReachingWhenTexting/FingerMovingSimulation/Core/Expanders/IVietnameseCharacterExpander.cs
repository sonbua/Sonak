using System.Collections.Generic;

namespace FingerMovingSimulation.Core.Expanders
{
    internal interface IVietnameseCharacterExpander
    {
        IEnumerable<char> Expand(char c);
        
        IEnumerable<char> SpecialCharacterSet { get; }
    }
}