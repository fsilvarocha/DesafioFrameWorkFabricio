using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace frwkFabricioSIlva.Models
{
    [Table("AcessoTipoUsuario")]
    public class AcessoTipoUsuario
    {
        [Display(Name = ("Id"))]
        [Column("Id")]
        public int Id { get; set; }

        [ForeignKey("TipoUsuario")]
        public int TipoUsuarioId { get; set; }
        public virtual TipoUsuario TipoUsuario { get; set; }

        [Display(Name = ("Acesso Tipo Usuário"))]
        [Column("DescricaoFuncionalidade")]
        public string DescricaoFuncionalidade { get; set; }

    }
}
