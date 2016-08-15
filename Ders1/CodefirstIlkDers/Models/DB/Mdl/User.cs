using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodefirstIlkDers.Models.DB.Mdl
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string UserPass { get; set; }
        public bool IsDelete { get; set; }
    }
}