using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopOfProd.Models
{
    public class Order
    {
        public int Id { get; set; }
       
       
        public int userId { get; set; }
        [ForeignKey("userId")]
        public User User { get; set; }
        public DateTime CreatedDate { get; set; }
        public virtual ICollection<Product> Products { get; set; }

        //public int userId { get; set; }
    }
}
