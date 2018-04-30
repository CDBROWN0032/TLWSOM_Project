using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LittleWoodshopDB
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
        public decimal? Cost { get; set; }
        public bool? Downpayment { get; set; }
        public bool? PaidinFull { get; set; }
        public int CustomerId { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime? DateCompleted { get; set; }

        public virtual Customer customer { get; set; }
    }
}
