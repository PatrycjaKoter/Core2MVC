using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PieShop.Models
{
    public class Feedback
    {
        [BindNever]
        public int FeedbackId { get; set; }
        [Required]
        [StringLength(100, ErrorMessage ="Your name is required")]
        public string Name { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "Your e-mail is required")]
        public string Email { get; set; }
        public string Message { get; set; }
        public bool ContactMe { get; set; }
    }
}
