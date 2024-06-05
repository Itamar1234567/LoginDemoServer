using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LoginDemoServer.Models;

public partial class Grade
{
    [Column("EmailID")]
    [StringLength(100)]
    public string EmailId { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? Date { get; set; }

    [Column("Grade")]
    public int Grade1 { get; set; }

    [StringLength(100)]
    public string Subject { get; set; } = null!;

    [Key]
    public int Id { get; set; }

    [ForeignKey("EmailId")]
    [InverseProperty("Grades")]
    public virtual User Email { get; set; } = null!;
}
