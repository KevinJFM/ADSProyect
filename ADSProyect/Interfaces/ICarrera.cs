using ADSProyect.Models;

namespace ADSProyect.Interfaces
{
    public interface ICarrera
    {
        public int AgregarCarrera(Carrera carrera);
        public int ActualizarCarrera(int idCarrera, Carrera carrera);
        public bool EliminarCarrera(int idCarrera);
        public List<Carrera> ConsultarTodasLasCarreras();
        public Carrera ConsultarCarreraPorID(int idCarrera);
    }
}

