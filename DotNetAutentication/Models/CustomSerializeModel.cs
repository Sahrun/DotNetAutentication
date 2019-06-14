using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotNetAutentication.Models
{
    public class CustomSerializeModel
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IList<string> RoleName { get; set; }
    }
}