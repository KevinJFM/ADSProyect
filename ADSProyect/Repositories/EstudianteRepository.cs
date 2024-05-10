using ADSProyect.DB;
using ADSProyect.Interfaces;
using ADSProyect.Migrations;
using ADSProyect.Models;

namespace ADSProyect.Repositories
{
    public class EstudianteRepository : IEstudiante
    {
        /*private List<Estudiante> lstEstudiantes = new List<Estudiante>
        {
            new Estudiante{ IdEstudiante = 1, NombresEstudiante = "Kevin Javier",
            ApellidosEstudiante = "Flores Mendoza", CodigoEstudiante = "FM19I04001",
            CorreoEstudiante = "fm19i04001@usonsonate.ed.sv"}
        };*/
        private readonly ApplicationDbContext applicationDbContext;

        public EstudianteRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        public int AgregarEstudiante(Estudiante estudiante)
        {
            try
            {
                /*if (lstEstudiantes.Count > 0)
                {
                    estudiante.IdEstudiante = lstEstudiantes.Last().IdEstudiante + 1;
                }
                lstEstudiantes.Add(estudiante);*/

                applicationDbContext.Estudiante.Add(estudiante);    
                applicationDbContext.SaveChanges();

                return estudiante.IdEstudiante;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int ActualizarEstudiante(int idEstudiante, Estudiante estudiante)
        {
            try
            {
                var item = applicationDbContext.Estudiante.SingleOrDefault(x => x.IdEstudiante == idEstudiante);

                applicationDbContext.Entry(item).CurrentValues.SetValues(estudiante);  
                
                applicationDbContext.SaveChanges();

                return idEstudiante;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool EliminarEstudiante(int idEstudiante)
        {
            try
            {
                /*int indice = lstEstudiantes.FindIndex(tmp => tmp.IdEstudiante == idEstudiante);

                lstEstudiantes.RemoveAt(indice);*/
                var item = applicationDbContext.Estudiante.SingleOrDefault(x => x.IdEstudiante == idEstudiante);

                applicationDbContext.Estudiante.Remove(item);

                applicationDbContext.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Estudiante ObtenerEstudiantePorID(int idEstudiante)
        {

            try
            {
                //Estudiante estudiante = lstEstudiantes.FirstOrDefault(tmp => tmp.IdEstudiante == idEstudiante);
                var estudiante = applicationDbContext.Estudiante.SingleOrDefault(x => x.IdEstudiante == idEstudiante);

                return estudiante;
            }
            catch (Exception)
            {
                throw;
            }

        }

        public List<Estudiante> ObtenerTodosLosEstudiantes()
        {
            try 
            {
                //return lstEstudiantes;
                return applicationDbContext.Estudiante.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
