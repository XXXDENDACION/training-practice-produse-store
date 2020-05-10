using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Core.Objects.DataClasses;

namespace ShopOfProd.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public string LogName { get; set; }
        [Required]
        public string Password { get; set; }
        public string Status { get; set; }
        public string Photo { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        
        
    }
}
