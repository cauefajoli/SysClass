using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SysClass.Models
{
    public class SysClassContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public SysClassContext() : base("name=SysClassContext")
        {
        }

        public System.Data.Entity.DbSet<SysClass.Models.Aluno> Alunoes { get; set; }

        public System.Data.Entity.DbSet<SysClass.Models.Curso> Cursoes { get; set; }

        public System.Data.Entity.DbSet<SysClass.Models.Professor> Professors { get; set; }
    }
}
