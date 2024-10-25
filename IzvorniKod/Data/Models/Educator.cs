using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Data.Models;

public class Educator
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long IdEducator { get; set; }

    [Required]
    [ForeignKey("User")]
    public long IdUser { get; set; }

    [Required]
    public bool Approved { get; set; }

    public User User { get; set; } // navigation property; not a column in the table
}
