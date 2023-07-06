﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Vezeeta.Models
{
    [Index("email", Name = "email_Punique", IsUnique = true)]
    [Index("phone", Name = "phone_Punique", IsUnique = true)]
    public partial class Patient
    {
        public Patient()
        {
            Patient_Appoinments = new HashSet<Patient_Appoinment>();
            Prescriptions = new HashSet<Prescription>();
            Questions = new HashSet<Question>();
            Reviews = new HashSet<Review>();
        }

        [Key]
        public int id { get; set; }
        [Required]
        [StringLength(50)]
        public string name { get; set; }
        [Required]
        [StringLength(250)]
        public string email { get; set; }
        [Required]
        [StringLength(12)]
        public string phone { get; set; }
        [Column(TypeName = "date")]
        public DateTime birth_date { get; set; }
        [Required]
        [StringLength(1)]
        public string gender { get; set; }
        [StringLength(150)]
        public string address { get; set; }
        [StringLength(50)]
        public string state { get; set; }
        [Required]
        [StringLength(150)]
        public string password { get; set; }
        [Column(TypeName = "date")]
        public DateTime? create_at { get; set; }
        [Column(TypeName = "date")]
        public DateTime? update_at { get; set; }
        public bool is_deleted { get; set; }

        [InverseProperty("patient")]
        public virtual ICollection<Patient_Appoinment> Patient_Appoinments { get; set; }
        [InverseProperty("patient")]
        public virtual ICollection<Prescription> Prescriptions { get; set; }
        [InverseProperty("patient")]
        public virtual ICollection<Question> Questions { get; set; }
        [InverseProperty("patient")]
        public virtual ICollection<Review> Reviews { get; set; }
    }
}