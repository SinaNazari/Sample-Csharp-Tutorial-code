using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction_PartialClass
{
    public partial class Profile
    {
        public void Show()
        {
            Console.WriteLine("Author Name is:" + AuthorName);
            Console.WriteLine("TotalBooks N is:" + TotalBooks);
        }
    }
}
