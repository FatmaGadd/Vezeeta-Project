﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Vezeeta.Models
{
    public partial class Clinic
    {
        public Clinic()
        {
            Addresses = new HashSet<Address>();
            Drs = new HashSet<Doctor>();
        }

        [Key]
        public int id { get; set; }
        [Required]
        [StringLength(50)]
        public string name { get; set; }
        [Required]
        [StringLength(12)]
        public string phone { get; set; }

        [InverseProperty("clinicNavigation")]
        public virtual ICollection<Address> Addresses { get; set; }

        [ForeignKey("clinic_id")]
        [InverseProperty("clinics")]
        public virtual ICollection<Doctor> Drs { get; set; }
    }
}