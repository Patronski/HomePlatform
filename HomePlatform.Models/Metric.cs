namespace HomePlatform.Data
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Metric
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Metric()
        {
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }
    }
}
