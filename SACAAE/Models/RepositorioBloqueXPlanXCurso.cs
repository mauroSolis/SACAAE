﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SACAAE.Models
{
    public class RepositorioBloqueXPlanXCurso
    {

        private SACAAEEntities entidades = new SACAAEEntities();


        public IQueryable<Curso> ListarCursosXBloque(int pBloqueID)
        {
            return from cursos in entidades.Cursos
                   join BPC in entidades.BloqueXPlanXCursoes on cursos.ID equals BPC.CursoID
                   join BloquesXPlan in entidades.BloqueAcademicoXPlanDeEstudios on BPC.BloqueXPlanID equals BloquesXPlan.ID
                   where BloquesXPlan.BloqueID == pBloqueID
                   select cursos;
        }

        public IQueryable<Curso> ListarCursosXPlan(int pPlanID)
        {
            return from cursos in entidades.Cursos
                   join BPC in entidades.BloqueXPlanXCursoes on cursos.ID equals BPC.CursoID
                   join BloquesXPlan in entidades.BloqueAcademicoXPlanDeEstudios on BPC.BloqueXPlanID equals BloquesXPlan.ID
                   where BloquesXPlan.PlanID == pPlanID
                   select cursos;
        }


        public bool existeRelacionBloqueXPlanXCurso(int pBloqueXPlanID, int pCursoID)
        {
            return (entidades.BloqueXPlanXCursoes.SingleOrDefault(relacion => relacion.BloqueXPlanID == pBloqueXPlanID && relacion.CursoID == pCursoID) != null);
        }

        public bool existeRelacionCursoEnPlan(int pPlanID, int pCursoID)
        {
            var request = from cursos in entidades.Cursos
                          join BloqueXPlanXCursos in entidades.BloqueXPlanXCursoes on cursos.ID equals BloqueXPlanXCursos.CursoID
                          join BloqueXPlan in entidades.BloqueAcademicoXPlanDeEstudios on BloqueXPlanXCursos.BloqueXPlanID equals BloqueXPlan.ID
                          where cursos.ID == pCursoID && BloqueXPlan.PlanID == pPlanID
                          select BloqueXPlanXCursos;
            if (request.Any())
                return true;
            return false;
        }

        public void crearRelacionBloqueXPlanXCurso(BloqueXPlanXCurso pBloqueXPlanXCurso)
        {
            if (existeRelacionBloqueXPlanXCurso(pBloqueXPlanXCurso.BloqueXPlanID, pBloqueXPlanXCurso.CursoID))
                return;
            else
            {
                entidades.BloqueXPlanXCursoes.Add(pBloqueXPlanXCurso);
                Save();
            }
        }

        private void Save()
        {
            entidades.SaveChanges();
        }

    }
}