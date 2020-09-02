using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace frwkFabricio.Models
{
    [Table("Paciente")]
    public class Paciente
    {
        [Display(Name = "Id")]
        [Column("Id")]
        public int Id { get; set; }

        [Display(Name = ("Pais"))]
        [ForeignKey("Pais")]
        public int PaisId { get; set; }
        public virtual Pais Pais { get; set; }

        [Display(Name = ("Estado"))]
        [ForeignKey("Estado")]
        public int EstadoId { get; set; }
        public virtual Estado Estado { get; set; }

        [Display(Name = ("Cidade"))]
        [ForeignKey("Cidade")]
        public int CidadeId { get; set; }
        public virtual Cidade Cidade { get; set; }


        [Display(Name = "Nome")]
        [Column("Nome")]
        public string Nome { get; set; }

        [Display(Name = "Cpf")]
        [Column("Cpf")]
        public string Cpf { get; set; }
    }
}
