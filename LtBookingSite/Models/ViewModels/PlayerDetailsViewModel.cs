﻿using System;
using System.ComponentModel.DataAnnotations;

namespace LtBookingSite.Models.ViewModels
{
    public class PlayerDetailsViewModel
    {
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Player ID")]
        public int? PlayerId { get; set; }

        [Required]
        [Display(Name = "Date of Birth")]
        public DateTime? DateOfBirth { get; set; }

        [Required]
        [Display(Name = "Emergency Contact Name")]
        public string EmergencyContactName { get; set; }

        [Required]
        [Phone]
        [Display(Name = "Emergency Contact Phone Number")]
        public string EmergencyContactPhoneNumber { get; set; }

        [Display()]
        public string Notes { get; set; }
    }
}
