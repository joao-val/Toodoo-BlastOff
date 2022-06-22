using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa_01.Models
{
    [Table("Galaxy")]
    public class Galaxy
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
        [MaxLength(50)]
        [Column("Type", TypeName = "VARCHAR")]
        public string Type { get; set; }
    }
}
