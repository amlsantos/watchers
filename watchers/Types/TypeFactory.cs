using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using watchers.Forms;

namespace watchers.Types;

internal class TypeFactory
{
    public IType CreateType(string type)
    {
        switch (type)
        {
            case "type1":
                return new Type1();
            case "type2":
                return new Type2();
            case "type3":
                return new Type3();
            case "type4":
                return new Type4();
            default:
                throw new ArgumentOutOfRangeException($"invalid type {type}");
        }
    }

    public bool IsValidType(string type)
    {
        var types = new List<string>
        {
            "type1",
            "type2",
            "type3",
            "type4"
        };

        return types.Contains(type);
    }
}
