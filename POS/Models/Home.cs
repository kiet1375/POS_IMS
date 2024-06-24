﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POS.Models
{
    public class Home
    {
        [Key]
        [MaxLength(128)]
        public string HomeId { get; set; }

        [Required]
        [MaxLength(150)]
        public string UserName { get; set; }

        [ForeignKey(nameof(UserName))]
        public User User { get; set; }
    }
}