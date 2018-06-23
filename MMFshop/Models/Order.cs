using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
namespace Models
{
    [DataContract]
    public class Order
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        [Required]
        public string OrderName { get; set; }
        [DataMember]
        [Required]
        public decimal Price { get; set; }
        [DataMember]
        [Required]
        public int CustomerID { get; set; }

        [ForeignKey("OrderId")]
        public virtual List<Entry> Entrys { get; set; }

        [ForeignKey("OrderId")]
        public virtual List<OrderFurniture> OrderFurnitures { get; set; }
    }
}
