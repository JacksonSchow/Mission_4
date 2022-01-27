using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Film_Collection.Models
{
    // New model with the same fields as Joel's spreadsheet. I added the key for database purposes. Fields that need to be required are required and the Notes field has a max length of 25
    public class MoviesModel
    {
        [Key]
        [Required]
        public int FormId { get; set; }

        [Required]
        public string Category { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        public string Director { get; set; }

        [Required]
        public string Rating { get; set; }

        public bool Edited { get; set; }

        public string Lent_To { get; set; }

        [MaxLength (25)]
        public string Notes { get; set; }
    }
}
