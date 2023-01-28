using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoulsFormats;

namespace ACFAParamEditor
{
    internal class ParamWrapper
    {
        internal string ParamName { get; init; }
        internal PARAM Param { get; init; }
        public override string ToString() => ParamName;
    }
}
