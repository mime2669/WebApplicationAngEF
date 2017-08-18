using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplicationAngEF.Data
{
    public class Shop
    {
        public int Id { get; set; }

        [Index("IX_Unique_Entry", 1, IsUnique = true)]
        [MaxLength(150)]
        public string Name { get; set; }

        [Index("IX_Unique_Entry", 2, IsUnique = true)]
        [MaxLength(255)]
        public string Address { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}