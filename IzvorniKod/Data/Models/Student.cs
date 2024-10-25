using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Data.Models;

public class Student
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long IdStudent { get; set; }
    public Guid Guid { get; set; }

    [Required]
    [ForeignKey("User")]
    public long IdUser { get; set; }

    public User User { get; set; } // navigation property; not a column in the table
}
