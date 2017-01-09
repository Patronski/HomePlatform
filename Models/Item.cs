namespace HomePlatform.Data
{
    public partial class Item
    {
        public int Id { get; set; }

        public int? ItemTypeId { get; set; }

        public int? Quantity { get; set; }

        public int? MetricId { get; set; }

        public string Note { get; set; }

        public int? LocationId { get; set; }

        public virtual ItemType ItemType { get; set; }

        public virtual Location Location { get; set; }

        public virtual Metric Metric { get; set; }
    }
}
