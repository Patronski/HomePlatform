namespace HomePlatform.Data
{
    using System.Data.Entity;

    public partial class HomeContext : DbContext
    {
        public HomeContext()
            : base("name=HomeContext")
        {
        }

        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<ItemType> ItemTypes { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Metric> Metrics { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
