using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SysClass.Models
{
    public class Curso
    {
        [Key]
        public int ID { get; set; }
        public String Nome { get; set; }
        public Professor Professor { get; set; }
    }
}