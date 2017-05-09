using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SysClass.Models
{
    public class Professor
    {
        [Key]
        public int ID { get; set; }
        public String Nome { get; set; }
        public virtual ICollection<Curso> Cursos { get; set; }
    }
}