using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginDemoApp.Models
{
    public class Grade
    {
        
        public DateTime Date { get; set; }


        public string SubjectName { get; set; } = null!;

        public int TestGrade { get; set; }


        public string Email { get; set; } = null!;

        public virtual User EmailNavigation { get; set; } = null!;
    }
}
