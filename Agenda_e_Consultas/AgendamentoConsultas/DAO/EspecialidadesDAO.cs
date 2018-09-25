using System;
using System.Collections.Generic;
using System.Linq;
using AgendamentoConsultas.Models;

namespace AgendamentoConsultas.DAO
{
    public class EspecialidadesDAO
    {
        public void Adiciona(Especialidade especialidade)
        {
            using (var context = new ClinicaContext())
            {
                context.Especialidades.Add(especialidade);
                context.SaveChanges();
            }


        }
        public IList<Especialidade> Lista()
        {
            using (var contexto = new ClinicaContext())
            {
                return contexto.Especialidades.ToList();
            }
        }
        public void Atualiza(Especialidade especialidade)
        {
            using (var contexto = new ClinicaContext())
            {
                contexto.Update(especialidade);
                contexto.SaveChanges();
            }
        }
        public Especialidade BuscaPorId(int id)
        {
            using (var contexto = new ClinicaContext())
            {
                return contexto.Especialidades.Where(p => p.Id == id).FirstOrDefault();
            }
        }
    }
}