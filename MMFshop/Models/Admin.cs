using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
namespace Models
{
    [DataContract]
    public class Admin
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        [Required]
        public string AdminLogin { get; set; }
        [DataMember]
        [Required]
        public string AdminPassword { get; set; }
    }
}
