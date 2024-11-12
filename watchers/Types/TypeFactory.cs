using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using watchers.Forms;

namespace watchers.Types;

internal class TypeFactory
{
    private readonly Dictionary<string, IType> _types;

    public TypeFactory()
    {
        _types = new Dictionary<string, IType>()
        {
            { "type1", new Type1() },
            { "type2", new Type2() },
            { "type3", new Type3() },
            { "type4", new Type4() },
        };
    }

    public IType CreateType(string type)
    {
        if (!IsValidType(type))
        {
            //throw new ArgumentOutOfRangeException($"invalid type {type}");
            return new NullType();
        }

        return _types[type];
    }

    public bool IsValidType(string type)
    {
        return _types.ContainsKey(type);
    }
}
