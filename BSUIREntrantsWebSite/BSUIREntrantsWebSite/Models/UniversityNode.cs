using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BSUIREntrantsWebSite.Models
{
    public class UniversityNode
    {
        public string id { get; set; }
        public string parentId { get; set; }
        public string text { get; set; }
        public bool children { get; set; }
    }
}