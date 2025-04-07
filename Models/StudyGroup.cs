﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Runtime.ExceptionServices;

namespace U23957281_Prac_4.Models
{
    public class StudyGroup
    {
        [Display(Name = "Student Number")]
        public string StudentNo { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }

        [Display(Name = "Link to personal page")]
        public string myLink { get; set; }

        [Display(Name = "Delete")]
        public bool Delete { get; set; }
    }
}