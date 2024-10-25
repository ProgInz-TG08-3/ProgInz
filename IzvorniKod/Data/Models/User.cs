using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Data.Models;

public class User
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long IdUser { get; set; }
    public Guid Guid { get; set; }

    [Required]
    [StringLength(1000)]
    public string Password { get; set; }

    [Required]
    [StringLength(100)]
    public string Mail { get; set; }

    // navigational properties
    public Student? Student { get; set; }
    public Educator? Educator { get; set; }
    public Administrator? Administrator { get; set; }
    public Reviewer? Reviewer { get; set; }
}
