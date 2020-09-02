using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace frwkFabricioSIlva.Models
{
    [Table("PerfilUsuario")]
    public class PerfilUsuario
    {
        [Display(Name = ("Id"))]
        [Column("Id")]
        public int Id { get; set; }

        [ForeignKey("TipoUsuario")]
        public int TipoUsuarioId { get; set; }
        public virtual TipoUsuario TipoUsuario { get; set; }

        [Display(Name = ("Usuario"))]
        [ForeignKey("IdentityUser")]
        [Column(Order = 1)]
        public string UserId { get; set; }
        public virtual IdentityUser IdentityUser { get; set; }
    }
}
