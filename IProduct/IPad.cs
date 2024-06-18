using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IProduct
{
    internal class IPad : IProduct
    {
        public string ProductName { get; set; } = string.Empty;
        public string Color { get; set; } = string.Empty;
        public decimal Price { get; set; } = 0m;
        public string Memory { get; set; } = string.Empty;

        
    }
}
