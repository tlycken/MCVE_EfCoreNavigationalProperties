using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreOnExistingDb.Entities
{
    public class Foo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FooId { get; set; }

        [Required]
        public string Qux { get; set; }

        [Required]
        [ForeignKey("Bar_BarId")]
        public Bar Bar { get; set; }
    }

    public class Bar
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BarId { get; set; }

        [Required]
        public string Baz { get; set; }
    }
}