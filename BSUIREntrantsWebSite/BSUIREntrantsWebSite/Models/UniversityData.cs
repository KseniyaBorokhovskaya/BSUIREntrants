using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BSUIREntrantsWebSite.Models
{
    public class UniversityData
    {
        public string Id { get; set; }
        public string Text { get; set; }
        public ICollection<UniversityNode> Nodes { get; set; }
    }
}