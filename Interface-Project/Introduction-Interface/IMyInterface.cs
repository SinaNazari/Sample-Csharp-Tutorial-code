using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction_Interface
{
    public interface IMyInterface
    {
        string Name(string value);
        string Family(string value);
        string UniqueKey(string value);
        string AccessLevel(string value);
    }
}
