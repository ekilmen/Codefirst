using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirstRelations.Models.DB.Mdl
{
    public class UserMsg
    {
        public int UserMsgId { get; set; }
        public int UserId { get; set; }
        public string MessageText { get; set; }
    }
}