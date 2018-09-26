using AgendamentoConsultas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AgendamentoConsultas.DAO
{
    public class PacienteDAO
    {
        public void Adiciona(Paciente paciente)
        {
            using (var context = new ClinicaContext())
            {
                context.Pacientes.Add(paciente);
                context.SaveChanges();
            }


        }
        public IList<Paciente> Lista()
        {
            using (var contexto = new ClinicaContext())
            {
                return contexto.Pacientes.ToList();
            }
        }
        public void Atualiza(Paciente paciente)
        {
            using (var contexto = new ClinicaContext())
            {
                contexto.Update(paciente);
                contexto.SaveChanges();
            }
        }
        public Paciente BuscaPorId(int id)
        {
            using (var contexto = new ClinicaContext())
            {
                return contexto.Pacientes.Where(p => p.Id == id).FirstOrDefault();
            }
        }
        public void Remover(Paciente paciente)
        {
            using (var contexto = new ClinicaContext())
            {
                contexto.Pacientes.Remove(paciente);
                contexto.SaveChanges();
            }
        }
    }
}
