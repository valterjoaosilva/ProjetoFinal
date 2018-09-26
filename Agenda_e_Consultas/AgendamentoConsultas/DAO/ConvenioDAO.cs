using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AgendamentoConsultas.Models;

namespace AgendamentoConsultas.DAO
{
    public class ConvenioDAO
    {
        public void Adiciona(Convenio convenio)
        {
            using (var context = new ClinicaContext())
            {
                context.Convenios.Add(convenio);
                context.SaveChanges();
            }


        }
        public IList<Convenio> Lista()
        {
            using (var contexto = new ClinicaContext())
            {
                return contexto.Convenios.ToList();
            }
        }
        public void Atualiza(Convenio convenio)
        {
            using (var contexto = new ClinicaContext())
            {
                contexto.Update(convenio);
                contexto.SaveChanges();
            }
        }
        public Convenio BuscaPorId(int id)
        {
            using (var contexto = new ClinicaContext())
            {
                return contexto.Convenios.Where(p => p.Id == id).FirstOrDefault();
            }
        }
        public void Remover(Convenio convenio)
        {
            using (var contexto = new ClinicaContext())
            {
                contexto.Convenios.Remove(convenio);
                contexto.SaveChanges();
            }
        }
    }
}