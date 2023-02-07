using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission05_dbdecker.Models
{
    public class GradesModel
    {
        [Required]
        [Range(0, 100, ErrorMessage = "Grade must be between 0 and 100")]
        public int Assignments { get; set; }
        [Required]
        [Range(0, 100, ErrorMessage = "Grade must be between 0 and 100")]
        public int GroupProject { get; set; }
        [Required]
        [Range(0, 100, ErrorMessage = "Grade must be between 0 and 100")]
        public int Quizzes { get; set; }
        [Required]
        [Range(0, 100, ErrorMessage = "Grade must be between 0 and 100")]
        public int MidtermExam { get; set; }
        [Range(0, 100, ErrorMessage = "Grade must be between 0 and 100")]
        public int FinalExam { get; set; }
        [Required]
        [Range(0, 100, ErrorMessage = "Grade must be between 0 and 100")]
        public int Intex { get; set; }

    }
}
