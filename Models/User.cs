namespace HomePlatform.Data
{
    using System.ComponentModel.DataAnnotations;

    public partial class User
    {
        [Key]
        [StringLength(50)]
        public string Username { get; set; }

        [Required]
        [StringLength(50)]
        public string Password { get; set; }
    }
}
