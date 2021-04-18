using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleCMS.Models
{
    public class Block
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BlockId { get; set; }
        public string ImagePath { get; set; }
        public bool IsHidden { get; set; }
        public string Headline { get; set; }
        public string Text { get; set; }
        public Section Section { get; set; }
        public string BackgroundColor { get; set; }

    }
}
