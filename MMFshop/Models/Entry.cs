using System;

namespace Models
{
    public class Entry
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }

        public int FurnitureId { get; set; }

        public int? ConsultantId { get; set; }

        public int AdminId { get; set; }

        public int Count { get; set; }

        public decimal Sum { get; set; }

        public PaymentState Status { get; set; }

        public DateTime DateCreate { get; set; }

        public DateTime? DateImplement { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Furniture Furniture { get; set; }

        public virtual Consultant Consultant { get; set; }

    }
}
