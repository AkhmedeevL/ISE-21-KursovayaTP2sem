using Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace Service
{
    [Table("MMFshopTable")]
    public class MMFdbContext : DbContext
    {
        public MMFdbContext()
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
            var ensureDLLIsCopied = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }

        public virtual DbSet<Admin> Admins { get; set; }

        public virtual DbSet<Customer> Customers { get; set; }

        public virtual DbSet<Part> Parts { get; set; }

        public virtual DbSet<Consultant> Consultants { get; set; }

        public virtual DbSet<Entry> Entrys { get; set; }

        public virtual DbSet<Furniture> Furnitures { get; set; }

        public virtual DbSet<FurniturePart> FurnitureParts { get; set; }

    }
}
