using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreOnExistingDb.Entities
{
    public class Foo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long FooId { get; set; }

        [Required]
        public string Qux { get; set; }

        [Required]
        public Bar Bar { get; set; }
    }

    public class Bar
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long BarId { get; set; }

        [Required]
        public string Baz { get; set; }
    }
}