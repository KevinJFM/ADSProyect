using ADSProyect.Models;

namespace ADSProyect.Interfaces
{
    public interface IMateria
    {
        public int AgregarMateria(Materia materia);
        public int ActualizarMateria(int idMateria, Materia materia);

        public List<Materia> ObtenerTodasLasMaterias();

        public Materia ObtenerMateriaPorID(int idMateria);
        public bool EliminarMateria(int idMateria);
    }
}
