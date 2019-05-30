using System;
using System.Collections.Generic;
using System.Text;

namespace PortalITEdx.Domain
{
    public class Cursos
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double Preco { get; set; }
        public Departamento Departamento { get; set; }
    }
}
