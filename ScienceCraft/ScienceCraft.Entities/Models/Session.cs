﻿using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace ScienceCraft.Entities.Models
{
    public class Session
    {
        [Key]
        public int Id { get; set; }

        [Required,StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string Description { get; set; } = string.Empty;

        [Required]
        public DateTime CreatedTime { get; set; } = DateTime.Now;
        public DateTime LastModified { get; set; } = DateTime.Now;

        [Required]
        public string Content {  get; set; } = string.Empty;


        public int KitId { get; set; } = 0;

        [ValidateNever]
        public Kit? Kit { get; set; }

        
        [Required]
        public int CourseId { get; set; }

        [ValidateNever]
        public Course Course { get; set; }

        
        [Required]
        public int InscId { get; set; }

        [ValidateNever]
        public Employee Empolyee { get; set; }

    }
}