using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstASPNETWebApp.Models
{
    public class GradeWeightsModel
    {
        
        [Required]
        //getters and setters and bytes is the type and the range it will be
        public byte Assignments { get; set; }
  
        public byte Group { get; set; }

        public byte Quizzes { get; set; }

        public byte Exams { get; set; }

        public byte Intex { get; set; }

    }
}
