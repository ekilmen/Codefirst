using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirstRelations.Models.DB.Mdl
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string UserPass { get; set; }
        public int UserAuthId { get; set; }
        public bool IsDelete { get; set; }
        public virtual UserAuth Auth { get; set; }
        public virtual ICollection<UserMsg> Msg { get; set; }
    }
}