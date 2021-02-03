using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public interface IDish
    {
        void Prepare();
        string Name { get; }
    }
}
