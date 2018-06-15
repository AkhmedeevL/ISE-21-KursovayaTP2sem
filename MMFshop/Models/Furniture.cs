using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Furniture
    {
        public int Id { get; set; }

        [Required]
        public string FurnitureName { get; set; }

        [Required]
        public decimal Price { get; set; }

        [ForeignKey("FurnitureId")]
        public virtual List<Entry> Entrys { get; set; }

        [ForeignKey("FurnitureId")]
        public virtual List<FurniturePart> FurnitureParts { get; set; }
    }
}
