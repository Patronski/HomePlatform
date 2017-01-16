namespace HomePlatform.Data
{
    using System.Data.Entity;
    using System.Data.Entity.Migrations;

    public partial class HomeContext : DbContext
    {
        public HomeContext()
            : base("name=HomeContext")
        {
            if (Database.CreateIfNotExists())
            {
                SeedDatabase();
            }
        }

        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<ItemType> ItemTypes { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Metric> Metrics { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

        private void SeedDatabase()
        {
            Metrics.AddOrUpdate(
                m => m.Name,
                new Metric { Name = "кг" },
                new Metric { Name = "см" },
                new Metric { Name = "м" },
                new Metric { Name = "кубици" },
                new Metric { Name = "кутии" },
                new Metric { Name = "чували" },
                new Metric { Name = "буркани" },
                new Metric { Name = "чанти" },
                new Metric { Name = "шишета" },
                new Metric { Name = "стаи" }
            );

            ItemTypes.AddOrUpdate(
                it => it.Name,
                new ItemType { Name = "дърва" },
                new ItemType { Name = "лютеница" },
                new ItemType { Name = "домашни сокове" },
                new ItemType { Name = "доматен сок" },
                new ItemType { Name = "компоти" },
                new ItemType { Name = "брашно" },
                new ItemType { Name = "мед" }
            );

            this.SaveChanges();
        }

    }
}
