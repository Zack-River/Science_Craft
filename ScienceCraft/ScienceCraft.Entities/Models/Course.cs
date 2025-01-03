﻿using System.ComponentModel.DataAnnotations;

namespace ScienceCraft.Entities.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; } = "No Description";

        [Required]
        public DateTime CreatedTime { get; set; } = DateTime.Now;

        [Required]
        public DateTime LastModified { get; set; } = DateTime.Now;

        [Required]
        public string Image { get; set; } = "No Image";

        [Required]
        public bool Approval { get; set; } = false;

        public string Status { get; set; } = "Pending";
    }
}
