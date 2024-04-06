using ADSProyect.Interfaces;
using ADSProyect.Models;

namespace ADSProyect.Repositories
{
     public class GrupoRepository : IGrupo
        {

            private List<Grupo> lstGrupos = new List<Grupo>
            {
                new Grupo{ IdGrupo = 1, IdCarrera = 1,
                         IdMateria = 1, IdProfesor = 1,
                         Ciclo = 01, Anio = 2024}
            };

           public int AgregarGrupo(Grupo grupo)
            {
                try
                {
                    if (lstGrupos.Count > 0)
                    {
                        grupo.IdGrupo = lstGrupos.Last().IdGrupo + 1;
                    }
                    lstGrupos.Add(grupo);

                    return grupo.IdGrupo;
                }
                catch (Exception)
                {
                    throw;
                }
            }

            public List<Grupo> ConsultarGrupos()
            {
                try
                {
                    return lstGrupos;
                }
                catch (Exception)
                {
                    throw;
                }
            }

            public Grupo ConsultarGrupoPorID(int idGrupo)
            {
                try
                {
                    Grupo grupo = lstGrupos.Find(temp => temp.IdGrupo == idGrupo);
                    return grupo;
                }
                catch (Exception)
                {
                    throw;
                }
            }

            public bool EliminarGrupo(int idGrupo)
            {
                try
                {
                    int index = lstGrupos.FindIndex(temp => temp.IdGrupo == idGrupo);
                    lstGrupos.RemoveAt(index);
                    return true;
                }
                catch (Exception)
                {
                    throw;
                }
            }

            public int ModificarGrupo(int idGrupo, Grupo grupo)
            {
                try
                {
                    int index = lstGrupos.FindIndex(temp => temp.IdGrupo == idGrupo);
                    if (index != -1)
                    {
                        lstGrupos[index] = grupo;
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
