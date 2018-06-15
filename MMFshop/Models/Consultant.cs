using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Consultant
    {
        public int Id { get; set; }

        [Required]
        public string ConsultantFIO { get; set; }

        [ForeignKey("ConsultantId")]
        public virtual List<Entry> Entrys { get; set; }
    }
}
