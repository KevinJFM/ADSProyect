using ADSProyect.Models;

namespace ADSProyect.Interfaces
{
    public interface IProfesor
    {
        public int AgregarProfesor(Profesor profesor);
        public int ActualizarProfesor(int idProfesor, Profesor profesor);

        public List<Profesor> ObtenerTodosLosProfesores();

        public Profesor ObtenerProfesorPorID(int idProfesor);
        public bool EliminarProfesor(int idProfesor);
    }
}
