using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BSUIREntrantsWebSite.Models
{
    public class Enrollee
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string HomeTown { get; set; }
        public int TotalScore { get; set; }
        public DateTime BirthDate { get; set; }
    }
}