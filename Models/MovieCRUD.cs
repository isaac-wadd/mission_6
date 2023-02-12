
using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mission_6.Models {

// 'Movie' class to record data
    public class Movie {
        [Key]
        [Required]
        public int movieID { get; set; }
        [Required]
        public string category { get; set; }
        [Required]
        public string title { get; set; }
        [Required]
        public string year { get; set; }
        [Required]
        public string director { get; set; }
        [Required]
        public string rating { get; set; }
        [Required]
        public bool edited { get; set; } = false;
        public string lentTo { get; set; }
        [StringLength(25)]
        public string notes { get; set; }
    }
}
