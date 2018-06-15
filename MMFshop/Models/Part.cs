using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Part
    {
        public int Id { get; set; }

        [Required]
        public string PartName { get; set; }

        [ForeignKey("PartId")]
        public virtual List<FurniturePart> FurnitureParts { get; set; }
    }
}
