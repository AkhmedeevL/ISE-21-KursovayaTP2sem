using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        public string CustomerFIO { get; set; }

        [Required]
        public string CustomerLogin { get; set; }

        [Required]
        public string CustomerPassword { get; set; }

        [ForeignKey("CustomerId")]
        public virtual List<Entry> Entrys { get; set; }
    }
}
