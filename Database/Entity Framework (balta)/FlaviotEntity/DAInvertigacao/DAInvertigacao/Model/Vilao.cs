using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAInvestigacao.Model
{
    [Table("Vilao")]
    public class Vilao
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdVilao { get; set; }

        [Required]
        [MaxLength(45)]
        [Column("Nome", TypeName = "VARCHAR")]
        public string? Nome { get; set; }

        [Required]
        [Column("NumCrime", TypeName = "INT")]
        public int NumCrime { get; set; }
        public IList<Crime> Crimes { get; set; }
    }
}
