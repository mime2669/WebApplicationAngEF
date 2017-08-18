using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationAngEF.Data
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Shop> Shops { get; set; }
    }
}