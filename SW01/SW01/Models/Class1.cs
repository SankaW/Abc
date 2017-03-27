using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SW01.Models
{
    public partial class PersonModel
    {
        public int UserID { get; set; }
        public string FristName { get; set; }
        public string LastName { get; set; }
        public string GroupName { get; set; }
        public Nullable<System.DateTime> BirthDate { get; set; }
        public string Gender { get; set; }
        public Nullable<bool> Good { get; set; }
        public Nullable<bool> Bad { get; set; }
    }
}