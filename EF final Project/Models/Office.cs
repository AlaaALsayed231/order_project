﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_final_Project.Models
{
    public class Office
    {
        [Key]
        public int Code { get; set; }
        public string? City { get; set; }
        public string? Phone { get; set; }
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }
        public string? State { get; set; }
        public string? Country { get; set; }
        public int PostalCode { get; set; }
        public string? Territory { get; set; }

        public virtual ICollection<Employee> Employees { get; set; } = new HashSet<Employee>();


    }
}
