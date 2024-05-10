using ADSProyect.DB;
using ADSProyect.Interfaces;
using ADSProyect.Migrations;
using ADSProyect.Models;

namespace ADSProyect.Repositories
{
    public class CarreraRepository : ICarrera
    {

        /*private List<Carrera> lstCarreras = new List<Carrera>
        {
            new Carrera { IdCarrera = 1,
                           NombreCarrera = "Ingenieria en Sistemas Computacionales",
                           CodigoCarrera = "ISC"}
        };*/
        private readonly ApplicationDbContext applicationDbContext;
        public CarreraRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        public int AgregarCarrera(Carrera carrera)
        {
            try
            {
                /*if (lstCarreras.Count > 0)
                {
                    carrera.IdCarrera = lstCarreras.Last().IdCarrera + 1;
                }
                lstCarreras.Add(carrera);*/
                applicationDbContext.Carrrera.Add(carrera);
                applicationDbContext.SaveChanges();

                return carrera.IdCarrera;
            }
            catch (Exception)
            {
                throw ;
            }
        }

        public int ActualizarCarrera(int idCarrera, Carrera carrera)
        {
            try
            {
                /*int index = lstCarreras.FindIndex(temp => temp.IdCarrera == idCarrera);
                if (index != -1)
                {
                    lstCarreras[index] = carrera;
                    return 1;
                }
                else
                {
                    return 0;
                }*/

                var item = applicationDbContext.Carrrera.SingleOrDefault(x => x.IdCarrera == idCarrera);

                applicationDbContext.Entry(item).CurrentValues.SetValues(carrera);

                applicationDbContext.SaveChanges();

                return idCarrera;
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
                /*int index = lstCarreras.FindIndex(temp => temp.IdCarrera == idCarrera);
                lstCarreras.RemoveAt(index);*/
                var item = applicationDbContext.Carrrera.SingleOrDefault(x => x.IdCarrera == idCarrera);

                applicationDbContext.Carrrera.Remove(item);

                applicationDbContext.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Carrera> ConsultarTodasLasCarreras()
        {
            try
            {
                // return lstCarreras;
                return applicationDbContext.Carrrera.ToList();
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

                //Carrera carrera = lstCarreras.Find(temp => temp.IdCarrera == idCarrera);
                var carrera = applicationDbContext.Carrrera.SingleOrDefault(x => x.IdCarrera == idCarrera);
                return carrera;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

