﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Vezeeta.Models
{
    [Table("Patient_Appoinment")]
    public partial class Patient_Appoinment
    {
        public Patient_Appoinment()
        {
            Appointments = new HashSet<Appointment>();
        }

        public int patient_id { get; set; }
        [Column(TypeName = "date")]
        public DateTime? create_at { get; set; }
        [Key]
        public int id { get; set; }
        [StringLength(50)]
        public string state { get; set; }

        [ForeignKey("patient_id")]
        [InverseProperty("Patient_Appoinments")]
        public virtual Patient patient { get; set; }
        [InverseProperty("appoint")]
        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}