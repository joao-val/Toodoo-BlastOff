using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa_01.Models
{
    public class Star
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        [Column("Name", TypeName = "VARCHAR")]
        public string Name { get; set; }

        [Required]
        [Column("Mass", TypeName = "DECIMAL")]
        public decimal Mass { get; set; }

        [Required]
        [Column("Size", TypeName = "DECIMAL")]
        public decimal Size { get; set; }

        [Required]
        [Column("Luminosity", TypeName = "DECIMAL")]
        public decimal Luminosity { get; set; }

        [Required]
        [ForeignKey("FK_Galaxy_Stars")]
        [Column("GalaxyId", TypeName = "INT")]
        public int GalaxyId { get; set; }
        public Galaxy Galaxy { get; set; }
    }
}
