using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SysClass.Models
{
    public class Aluno
    {
        [Key]
        public int RA { get; set; }
        public String Nome { get; set; }
        public Curso Curso { get; set; }

    }
}