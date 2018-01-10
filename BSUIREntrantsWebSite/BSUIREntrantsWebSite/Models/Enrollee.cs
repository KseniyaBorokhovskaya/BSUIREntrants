using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}")]
        public DateTime BirthDate { get; set; }
        public string University { get; set; }
        public string Faculty { get; set; }
        public string Speciality { get; set; }
    }
}