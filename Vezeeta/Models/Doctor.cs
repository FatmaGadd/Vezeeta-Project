﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Vezeeta.Models
{
    [Index("email", Name = "email_unique", IsUnique = true)]
    public partial class Doctor
    {
        public Doctor()
        {
            Answers = new HashSet<Answer>();
            Appointments = new HashSet<Appointment>();
            Doctors_Phones = new HashSet<Doctors_Phone>();
            Prescriptions = new HashSet<Prescription>();
            Reviews = new HashSet<Review>();
            clinics = new HashSet<Clinic>();
        }

        [Key]
        public int id { get; set; }
        [Required]
        [StringLength(50)]
        public string email { get; set; }
        [Required]
        [StringLength(150)]
        public string password { get; set; }
        [StringLength(250)]
        public string image { get; set; }
        [Required]
        [StringLength(1)]
        public string gender { get; set; }
        public int experience { get; set; }
        [Column(TypeName = "date")]
        public DateTime birth_date { get; set; }
        [Required]
        [StringLength(150)]
        public string verification { get; set; }
        [StringLength(150)]
        public string status { get; set; }
        public int id_specialize { get; set; }
        [Column(TypeName = "date")]
        public DateTime? create_at { get; set; }
        [Column(TypeName = "date")]
        public DateTime? update_at { get; set; }
        public string description { get; set; }
        public int? no_of_views { get; set; }
        [StringLength(50)]
        public string waiting_time { get; set; }
        public bool is_deleted { get; set; }
        [Required]
        [StringLength(50)]
        public string name { get; set; }

        [ForeignKey("id_specialize")]
        [InverseProperty("Doctors")]
        public virtual Specialization id_specializeNavigation { get; set; }
        [InverseProperty("Dr")]
        public virtual ICollection<Answer> Answers { get; set; }
        [InverseProperty("Dr")]
        public virtual ICollection<Appointment> Appointments { get; set; }
        [InverseProperty("Dr")]
        public virtual ICollection<Doctors_Phone> Doctors_Phones { get; set; }
        [InverseProperty("Dr")]
        public virtual ICollection<Prescription> Prescriptions { get; set; }
        [InverseProperty("Dr")]
        public virtual ICollection<Review> Reviews { get; set; }

        [ForeignKey("Dr_id")]
        [InverseProperty("Drs")]
        public virtual ICollection<Clinic> clinics { get; set; }
    }
}