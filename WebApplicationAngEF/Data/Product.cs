using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplicationAngEF.Data
{
    public class Product
    {
        public int Id { get; set; }

        [Index("IX_Unique_Entry", 1, IsUnique = true)]
        [MaxLength(150)]
        public string Name { get; set; }

        public ICollection<Shop> Shops { get; set; }
    }
}