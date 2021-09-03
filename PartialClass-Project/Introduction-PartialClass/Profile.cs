using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction_PartialClass
{
    public partial class Profile
    {
        private string AuthorName;
        private int TotalBooks;


        public Profile(string name="Sina", int value=8)
        {
            this.AuthorName = name;
            this.TotalBooks = value;
        }
    }
}
