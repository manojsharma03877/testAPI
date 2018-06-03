using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APICode.Models
{
    public class ClassifiedModel
    {
        public int ClassifiedID { get; set; }
        public string ClassifiedTitle { get; set; }
        public string ClassifiedDetail { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ClassifiedImage { get; set; }
    }
}