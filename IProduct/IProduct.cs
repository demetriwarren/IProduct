using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IProduct
{
    internal interface IProduct
    {
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public string Color { get; set; }
        public string Memory { get; set; }
    }
}
