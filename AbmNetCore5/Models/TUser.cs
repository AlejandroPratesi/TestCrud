using System.ComponentModel.DataAnnotations;

namespace AbmNetCore5.Models
{
    public class TUser
    {
        [Key]
        public int CodUsuario { get; set; }
        public string TxtUser { get; set; }
        public string TxtPassword { get; set; }
        public string TxtNombre { get; set; }
        public string TxtApellido { get; set; }
        public string NroDoc { get; set; }
        public int? CodRol { get; set; }
        public int? SnActivo { get; set; }

       // public virtual TRol CodRolNavigation { get; set; }
    }
}
