using System.Runtime.Serialization;
namespace Models
{
    [DataContract]
    public class OrderFurniture
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int OrderId { get; set; }
        [DataMember]
        public int FurnitureId { get; set; }
        [DataMember]
        public int Count { get; set; }
        [DataMember]
        public decimal Price { get; set; }

        public virtual Order Order { get; set; }

        public virtual Furniture Furniture { get; set; }
    }
}
