using System;
using System.Runtime.Serialization;

namespace Models
{
    [DataContract]

    public class Entry
    {
        [DataMember]

        public int Id { get; set; }
        [DataMember]

        public int CustomerId { get; set; }
        [DataMember]

        public int OrderId { get; set; }
        [DataMember]

        public decimal Sum { get; set; }
        [DataMember]

        public decimal SumPay { get; set; }
        [DataMember]

        public PaymentState Status { get; set; }
        [DataMember]

        public DateTime DateCreate { get; set; }
        [DataMember]

        public string DateVisit { get; set; }
        [DataMember]

        public virtual Customer Customer { get; set; }
        [DataMember]

        public virtual Order Order { get; set; }

    }
}
