using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AgendamentoConsultas.Models
{
    public class Medico
    {
        public int Id { get; set; }
        public String Nome { get; set;  }
        public Especialidade Especialidade { get; set; }
        public String Convenio { get; set; }
        public int EspecialidadeId { get; set; }
        

    }
}