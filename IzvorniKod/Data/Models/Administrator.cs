using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Data.Models;

public class Administrator
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long IdAdministrator { get; set; }
    public Guid Guid { get; set; }

    [Required]
    [ForeignKey("User")]
    public long IdUser { get; set; }

    public User User { get; set; } // navigation property; not a column in the table
}
