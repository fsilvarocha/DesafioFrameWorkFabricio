using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace frwkFabricio.Models
{
    [Table("Cidade")]
    public class Cidade
    {
        [Display(Name = "Id")]
        [Column("Id")]
        public int Id { get; set; }

        [Display(Name = ("Estado"))]
        [ForeignKey("Estado")]
        public int EstadoId { get; set; }
        public virtual Estado Estado { get; set; }

        [Display(Name = "Descricao")]
        [Column("Descricao")]
        public string Descricao { get; set; }
    }
}
