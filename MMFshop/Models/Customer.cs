using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
namespace Models
{
    [DataContract]
    public class Customer
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        [Required]
        public string CustomerFIO { get; set; }
        [DataMember]
        public string Mail { get; set; }
        [DataMember]
        [Required]
        public string CustomerPassword { get; set; }

        [ForeignKey("CustomerId")]
        public virtual List<Entry> Entrys { get; set; }
    }
}
