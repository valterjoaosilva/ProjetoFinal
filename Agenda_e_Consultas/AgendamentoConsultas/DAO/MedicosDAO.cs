using AgendamentoConsultas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AgendamentoConsultas.DAO
{
    public class MedicosDAO
    {
        public void Adiciona(Medico medico)
        {
            using (var context = new ClinicaContext())
            {
                context.Medicos.Add(medico);
                context.SaveChanges();
            }


        }
        public IList<Medico> Lista()
        {
            using (var contexto = new ClinicaContext())
            {
                return contexto.Medicos.ToList();
            }
        }
        public void Atualiza(Medico medico)
        {
            using (var contexto = new ClinicaContext())
            {
                contexto.Update(medico);
                contexto.SaveChanges();
            }
        }
        public Medico BuscaPorId(int id)
        {
            using (var contexto = new ClinicaContext())
            {
                return contexto.Medicos.Where(p => p.Id == id).FirstOrDefault();
            }
        }
        public void Remover(Medico medico)
        {
            using (var contexto = new ClinicaContext())
            {
                contexto.Medicos.Remove(medico);
                contexto.SaveChanges();
            }
        }
    }
}