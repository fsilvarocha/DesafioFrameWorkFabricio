using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace frwkFabricioSIlva.Models
{
    [Table("TipoUsuario")]
    public class TipoUsuario
    {
        [Display(Name = ("Id"))]
        [Column("Id")]
        [Key]
        public int Id { get; set; }

        [Display(Name = ("Tipo Usuário"))]
        [Column("Descricao")]
        public string Descricao { get; set; }

    }
}
