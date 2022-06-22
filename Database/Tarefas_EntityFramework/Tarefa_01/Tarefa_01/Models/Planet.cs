using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa_01.Models
{
    [Table("Planet")]
    public class Planet
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        [Column("Name", TypeName = "VARCHAR")]
        public string Name { get; set; }

        [Column("Mass", TypeName = "DECIMAL")]
        public decimal? Mass { get; set; }

        [Required]
        [Column("Size", TypeName = "DECIMAL")]
        public decimal Size { get; set; }

        [Required]
        [Column("Habitable", TypeName = "BIT")]
        public bool Habitable { get; set; }

        [Required]
        [Column("Distance", TypeName = "DECIMAL")]
        public decimal Distance { get; set; }

        [Required]
        [ForeignKey("FK_Star_Planets")]
        [Column("StarId", TypeName = "INT")]
        public int StarId { get; set; }
        public Star Star { get; set; }
    }
}
