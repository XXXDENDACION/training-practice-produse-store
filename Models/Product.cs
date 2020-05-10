using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopOfProd.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string AboutFood { get; set; }

        public int categoryId { get; set; }
        [ForeignKey("categoryId")]
        public CategoryProducts Category { get; set; }
        public int Price { get; set; }
        public string Photo { get; set; }
        public virtual ICollection<Order> orders { get; set; }
    }
}
