using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AgendamentoConsultas.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        [MaxLength(11)]
        public string Cpf { get; set; }
        public string Senha { get; set; }
        

        //rg, endereco
    }
}