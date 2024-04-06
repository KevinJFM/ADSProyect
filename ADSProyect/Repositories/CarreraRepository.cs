using ADSProyect.Interfaces;
using ADSProyect.Models;

namespace ADSProyect.Repositories
{
    public class CarreraRepository : ICarrera
    {

        private List<Carrera> lstCarreras = new List<Carrera>
        {
            new Carrera { IdCarrera = 1,
                           NombreCarrera = "Ingenieria en Sistemas Computacionales",
                           CodigoCarrera = "ISC"}
        };
        public int AgregarCarrera(Carrera carrera)
        {
            try
            {
                if (lstCarreras.Count > 0)
                {
                    carrera.IdCarrera = lstCarreras.Last().IdCarrera + 1;
                }
                lstCarreras.Add(carrera);
                return carrera.IdCarrera;
            }
            catch (Exception)
            {
                throw ;
            }
        }

        public List<Carrera> ConsultarCarreras()
        {
            try
            {
                return lstCarreras;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Carrera ConsultarCarreraPorID(int idCarrera)
        {
            try
            {
                Carrera carrera = lstCarreras.Find(temp => temp.IdCarrera == idCarrera);
                return carrera;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool EliminarCarrera(int idCarrera)
        {
            try
            {
                int index = lstCarreras.FindIndex(temp => temp.IdCarrera == idCarrera);
                lstCarreras.RemoveAt(index);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int ModificarCarrera(int idCarrera, Carrera carrera)
        {
            try
            {
                int index = lstCarreras.FindIndex(temp => temp.IdCarrera == idCarrera);
                if (index != -1)
                {
                    lstCarreras[index] = carrera;
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

