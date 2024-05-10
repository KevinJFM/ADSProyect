using ADSProyect.DB;
using ADSProyect.Interfaces;
using ADSProyect.Migrations;
using ADSProyect.Models;
using Microsoft.AspNetCore.Mvc;

namespace ADSProyect.Repositories
{
    public class MateriaRepository : IMateria
    {
        /*private List<Materia> listitaMaterias = new List<Materia>
        {
            new Materia{IdMateria = 1, NombreMateria = "Estatica"}
        };*/

        private readonly ApplicationDbContext applicationDbContext;

        public MateriaRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        public int AgregarMateria(Materia materia)
        {
            try
            {
                /*if (listitaMaterias.Count > 0)
                {
                    materia.IdMateria = listitaMaterias.Last().IdMateria + 1;
                }
                listitaMaterias.Add(materia);*/
                applicationDbContext.Materia.Add(materia);
                applicationDbContext.SaveChanges();

                return materia.IdMateria;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int ActualizarMateria(int idMateria, Materia materia)
        {
            try
            {
                /*int bandera = 0;

                int index = listitaMaterias.FindIndex(tmp => tmp.IdMateria == idMateria);

                if (index >= 0)
                {
                    listitaMaterias[index] = materia;
                    bandera = idMateria;
                }
                else
                {
                    bandera = -1;
                }*/
                var item = applicationDbContext.Materia.SingleOrDefault(x => x.IdMateria == idMateria);

                applicationDbContext.Entry(item).CurrentValues.SetValues(materia);

                applicationDbContext.SaveChanges();

                return idMateria;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool EliminarMateria(int idMateria)
        {
            try
            {
                /*bool bandera = false;
                int index = listitaMaterias.FindIndex(aux => aux.IdMateria == idMateria);

                if (index >= 0)
                {
                    listitaMaterias.RemoveAt(index);
                    bandera = true;
                }*/
                var item = applicationDbContext.Materia.SingleOrDefault(x => x.IdMateria == idMateria);

                applicationDbContext.Materia.Remove(item);

                applicationDbContext.SaveChanges();

                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Materia ObtenerMateriaPorID(int idMateria)
        {
            try
            {
                // var materia = listitaMaterias.FirstOrDefault(tmp => tmp.IdMateria == idMateria);
                var materia = applicationDbContext.Materia.SingleOrDefault(x => x.IdMateria == idMateria);

                return materia;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Materia> ObtenerTodasLasMaterias()
        {
            try
            {
                //return listitaMaterias;
                return applicationDbContext.Materia.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
