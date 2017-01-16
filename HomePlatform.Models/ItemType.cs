namespace HomePlatform.Data
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class ItemType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ItemType()
        {
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }
    }
}
