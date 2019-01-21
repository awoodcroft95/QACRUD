﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace QACRUD.Models
{
    public class Accounts
    { 
        [Key]
        public int ID { get; set; }

        [Required]
        public string AccountName { get; set; }

        [Required]
        [StringLength(18, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [RegularExpression(@"^((?=.*[a-z])(?=.*[A-Z])(?=.*\d)).+$")]
        [DataType(DataType.Password)]
        [Display(Name ="Password")]
        public string AccountPassword { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? CreateDate { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? UpdateDate { get; set; }

        public string AccountDeatils { get; set; }
    }
}