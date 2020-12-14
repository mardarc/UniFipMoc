using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace UniFipMoc.Models
{
    public class Contexto : DbContext
    {
        public DbSet<Academico> Academicos { get; set; }
    }
}