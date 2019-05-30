using System;
using System.Collections.Generic;
using System.Text;

namespace PortalITEdx.Domain
{
    public class Departamento
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        List<Cursos> Cursos = new List<Cursos>();
    }
}
