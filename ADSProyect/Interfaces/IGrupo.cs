using ADSProyect.Models;

namespace ADSProyect.Interfaces
{
    public interface IGrupo
    {
        public int AgregarGrupo(Grupo grupo);
        public int ActualizarGrupo(int idGrupo, Grupo grupo);
        public bool EliminarGrupo(int idGrupo);
        public List<Grupo> ConsultarTodosLosGrupos();
        public Grupo ConsultarGrupoPorID(int idGrupo);
    }
}