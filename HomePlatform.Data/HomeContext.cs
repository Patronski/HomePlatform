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
                new Metric { Name = "��" },
                new Metric { Name = "��" },
                new Metric { Name = "�" },
                new Metric { Name = "������" },
                new Metric { Name = "�����" },
                new Metric { Name = "������" },
                new Metric { Name = "�������" },
                new Metric { Name = "�����" },
                new Metric { Name = "������" },
                new Metric { Name = "����" }
            );

            ItemTypes.AddOrUpdate(
                it => it.Name,
                new ItemType { Name = "�����" },
                new ItemType { Name = "��������" },
                new ItemType { Name = "������� ������" },
                new ItemType { Name = "������� ���" },
                new ItemType { Name = "�������" },
                new ItemType { Name = "������" },
                new ItemType { Name = "���" }
            );

            this.SaveChanges();
        }

    }
}
