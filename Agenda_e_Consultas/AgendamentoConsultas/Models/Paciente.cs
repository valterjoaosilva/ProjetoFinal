using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AgendamentoConsultas.Models
{
    public class Paciente
    {
        public int Id { get; set; }

        public String Nome { get; set; }
       
        public string Cpf { get; set; }
        public string DataNascimento { get; set; }
        public string Sexo { get; set; }
        public string Cep { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Complemento { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public int ConvenioId { get; set; }
        public Convenio Convenio { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string ConfirmarSenha { get; set; }
       
       

    }
}