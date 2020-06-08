using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PaginadoAspMvc.Models
{
    public class Persona : BaseModelo
    {
        public int Id { set; get; }
        public string Nombre { set; get; }
        public int edad { set; get; }
    }
}