using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bugs.Models
{
    [Table("BugModel")]
    public class BugModel
    {
        [Column("Id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption
            .Identity)]
        [Required]
        public Guid Id { get; set; }

        [Column("Description")]
        [Required]
        [StringLength(100)]
        public string Description { get; set; }

        [Column("Status")]
        [Required]
        public bool Status { get; set; }
    }
}
