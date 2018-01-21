using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BSUIREntrantsWebSite.Models
{
    public enum UniversityDataType
    {
        University,
        Faculty,
        Specialty,
        Specialization,
        FormOfStudy,
        Payment
    }

    public class UniversityNode
    {
        public string Id { get; set; }
        public string ParentId { get; set; }

        public string DataId { get; set; }
        public UniversityData Data { get; set; }

        public UniversityDataType TypeAndDepth { get; set; }

        public bool Children { get; set; }
    }
}