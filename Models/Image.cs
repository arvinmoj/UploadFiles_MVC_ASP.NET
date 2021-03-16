using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace My_Application.Models
{
    public class Image
    {
        public Image() : base()
        {
            ImageId = Guid.NewGuid();
        }

        [Key]
        public Guid ImageId { get; set; }
        
        [MaxLength(50)]
        public string Title { get; set; }

        [MaxLength(50)]
        public string ImageName { get; set; }

        [NotMapped]
        [Display(Name = "Upload File")]
        public IFormFile ImageFile { get; set; }
        
    }
}