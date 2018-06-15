namespace Models
{
    public class FurniturePart
    {
        public int Id { get; set; }

        public int FurnitureId { get; set; }

        public int PartId { get; set; }

        public decimal Count { get; set; }

        public virtual Furniture Furniture { get; set; }

        public virtual Part Part { get; set; }
    }
}
