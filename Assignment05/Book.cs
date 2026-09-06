using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment05
{
    internal class Book
    {
        private string password = "secret";
        internal int copiesInStock = 5;
        public string title = "MyBook";
        public Genre genre {  get; set; }

        
    }
}
