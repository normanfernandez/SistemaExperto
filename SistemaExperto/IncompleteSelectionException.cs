using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaExperto
{
    public class IncompleteSelectionException : Exception
    {
        public IncompleteSelectionException()
        {
        }
        public IncompleteSelectionException(string str) : base(str)
        {
        }
    }
}
