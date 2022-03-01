using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Op_CtrlFlow
{
    public class ScottishWeddingMaxException : ArgumentOutOfRangeException
    {
            public ScottishWeddingMaxException(string message) : base(message) { }
    }
}
