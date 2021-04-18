using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleCMS.Models
{
    public class Page
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PageId { get; set; }
        [Required]
        [StringLength(255, ErrorMessage = "max 255 characters")]
        public string Headline { get; set; }
        [StringLength(255, ErrorMessage = "max 255 characters")]
        public string Subheadline { get; set; }
        public bool HasImage { get; set; }
        public virtual ICollection<Section> Sections { get; set; }
        public string ImagePath { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "max 50 characters")]
        public string NavName { get; set; }
    }
}
