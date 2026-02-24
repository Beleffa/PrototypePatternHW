using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypeApp
{
    internal interface IMyCloneable<T>
    {
        T Clone();
    }
}
