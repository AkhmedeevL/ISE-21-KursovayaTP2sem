using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace Models
{
    [DataContract]

    public class Furniture
    {
        [DataMember]

        public int Id { get; set; }
        [DataMember]

        [Required]
        public string FurnitureName { get; set; }
        [DataMember]

        [Required]
        public decimal Price { get; set; }

        [ForeignKey("FurnitureId")]
        public virtual List<OrderFurniture> OrderFurnitures { get; set; }

    }
}
