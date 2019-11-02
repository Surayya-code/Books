using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppBooks
{  
    [Serializable]
    class Books
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public string Janr { get; set; }
        public string Lang { get; set; }
        public string Year { get; set; }
        public string Size { get; set; }
        public bool Rating { get; set; }

        public override string ToString()
        {
            return $"{Name} {Author} {Janr} {Lang} {Year}";
        }

    }
}
