using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction_Interface
{
    public class Employees : IMyInterface
    {
        public string Name(string value)
        {
            return  value;
        }

        public string Family(string value)
        {
            return value;
        }
        public string UniqueKey(string value)
        {
            return value;
        }

        public string AccessLevel(string value)
        {
            return value;
        }

    }
}
