using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace _2106Proj.Models
{
    public class Document
    {
        private String OwnerID { get; set; }
        private String DocumentID { get; set; }
        public DateTime DateCreated { get; set; }
        public String DocumentName { get; set; }
        public String Content { get; set; }
    }
}
