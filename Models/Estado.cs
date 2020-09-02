using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace frwkFabricio.Models
{
    [Table("Estado")]
    public class Estado
    {
        [Display(Name = "Id")]
        [Column("Id")]
        [Key]
        public int Id { get; set; }

        [Display(Name = ("Pais"))]
        [ForeignKey("Pais")]
        public int PaisId { get; set; }
        public virtual Pais Pais { get; set; }


        [Display(Name = "Descricao")]
        [Column("Descricao")]
        public string Descricao { get; set; }
    }
}
