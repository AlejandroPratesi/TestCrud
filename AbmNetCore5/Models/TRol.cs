using System.Collections.Generic;

namespace AbmNetCore5.Models
{
    public class TRol
    {
        public TRol()
        {
            TUsers = new HashSet<TUser>();
        }

        public int CodRol { get; set; }
        public string TxtDesc { get; set; }
        public int? SnActivo { get; set; }

        public virtual ICollection<TUser> TUsers { get; set; }
    }
}
