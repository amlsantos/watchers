using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace watchers.Types;

internal class NullType : IType
{
    public NullType()
    {
        Console.WriteLine("you are trying to create a invalid type");
    }
}
