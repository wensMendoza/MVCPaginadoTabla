using PaginadoAspMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PaginadoAspMvc.ViewModels
{
    public class IndexViewModels : BaseModelo
    {
        public List<Persona> personas { set; get; }
    }
}