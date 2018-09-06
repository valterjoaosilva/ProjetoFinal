using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AgendamentoConsultas.Models
{
    public class Paciente
    {
        public Usuario usuario { get; set; }
        public int usuarioId { get; set; }
        [MaxLength(11)]
        public string cpf { get; set; }
        public string datanascimento { get; set; }
        public string sexo { get; set; }
        [MaxLength(8)]
        public string cep { get; set; }
        public string endereco { get; set; }
        public string bairro { get; set; }
        public string complemento { get; set; }
        public string cidade { get; set; }
        public string uf { get; set; }
        [MaxLength(12)]
        public string telefone { get; set; }
        [MaxLength(13)]
        public string celular { get; set; }
        public string conveniomedico { get; set; }
        public string Email { get; set; }
        public string senha { get; set; }
        public string confirmarsenha { get; set; }
        public String Convenio { get; set; }
       

    }
}