using ADSProyect.Interfaces;
using ADSProyect.Models;

namespace ADSProyect.Repositories
{
    public class EstudianteRepository : IEstudiante
    {
        private List<Estudiante> lstEstudiantes = new List<Estudiante>
        {
            new Estudiante{ IdEstudiante = 1, NombresEstudiante = "Kevin Javier",
            ApellidosEstudiante = "Flores Mendoza", CodigoEstudiante = "FM19I04001",
            CorreoEstudiante = "fm19i04001@usonsonate.ed.sv"}
        };

        public int AgregarEstudiante(Estudiante estudiante)
        {
            try
            {
                if (lstEstudiantes.Count > 0)
                {
                    estudiante.IdEstudiante = lstEstudiantes.Last().IdEstudiante + 1;
                }
                lstEstudiantes.Add(estudiante);

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
                int indice = lstEstudiantes.FindIndex(tmp => tmp.IdEstudiante == idEstudiante);

                lstEstudiantes[indice] = estudiante;

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
                int indice = lstEstudiantes.FindIndex(tmp => tmp.IdEstudiante == idEstudiante);

                lstEstudiantes.RemoveAt(indice);

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
                Estudiante estudiante = lstEstudiantes.FirstOrDefault(tmp => tmp.IdEstudiante == idEstudiante);


                return estudiante;
            }
            catch (Exception)
            {
                throw;
            }

        }

        public List<Estudiante> ObtenerTodosLosEstudinates()
        {
            try 
            {
                return lstEstudiantes;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
