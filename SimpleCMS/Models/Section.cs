using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleCMS.Models
{
    public class Section
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SectionId { get; set; }
        [Required]
        [StringLength(255, ErrorMessage ="max 255 characters")]
        public string Headline { get; set; }
        [StringLength(255, ErrorMessage ="max 255 characters")]
        public string Subheadline { get; set; }
        public bool IsHidden { get; set; }
        public virtual ICollection<Block> Blocks { get; set; }
        public Page Page { get; set; }

        public string BackgroundColor { get; set; }

    }
}
