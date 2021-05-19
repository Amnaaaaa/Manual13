using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Date;

namespace PhonebookProject.Models
{
    public class Contact
    {
        private String name { get; set; }
        private Date dob { get; set; }
        private String contactNumber { get; set; }
        private String email { get; set; }

        private Date savedOn { get; set; }

    }
}