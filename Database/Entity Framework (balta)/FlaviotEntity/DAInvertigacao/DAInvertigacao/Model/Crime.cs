using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAInvestigacao.Model
{
    [Table("Crime")]
    public class Crime
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdCrime { get; set; }

        [Required]
        [Column("Data", TypeName = "DATETIME")]
        public DateTime? Data { get; set; }

        [Required]
        [MaxLength(45)]
        [Column("Nome", TypeName = "VARCHAR")]
        public string? Nome { get; set; }

        [MaxLength(45)]
        [Column("Local", TypeName = "VARCHAR")]
        public string? Local { get; set; }

        [Column("Duracao", TypeName = "INT")]
        public int Duracao { get; set; }

        [ForeignKey("VilaoIdVilao")]
        public int VilaoIdVilao { get; set; }
        public Vilao? Vilao { get; set; }
    }
}