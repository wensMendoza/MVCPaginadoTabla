using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PaginadoAspMvc.Models
{
    public class ContextMvc : DbContext
    {
        public ContextMvc() : base("cnx") {}

        public DbSet<Persona> Personas { set; get; }

    }
}