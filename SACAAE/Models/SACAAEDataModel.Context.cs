﻿

//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace SACAAE.Models
{

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;


public partial class SACAAEEntities : DbContext
{
    public SACAAEEntities()
        : base("name=SACAAEEntities")
    {

    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }


    public DbSet<Comisione> Comisiones { get; set; }

    public DbSet<ComisionesXProfesor> ComisionesXProfesors { get; set; }

    public DbSet<Curso> Cursos { get; set; }

    public DbSet<CursosXGrupo> CursosXGrupoes { get; set; }

    public DbSet<Detalle_Curso> Detalle_Curso { get; set; }

    public DbSet<Estado> Estadoes { get; set; }

    public DbSet<Grupo> Grupoes { get; set; }

    public DbSet<Horario> Horarios { get; set; }

    public DbSet<Modalidade> Modalidades { get; set; }

    public DbSet<Periodo> Periodos { get; set; }

    public DbSet<PlanesDeEstudio> PlanesDeEstudios { get; set; }

    public DbSet<PlanesDeEstudioXSede> PlanesDeEstudioXSedes { get; set; }

    public DbSet<Profesore> Profesores { get; set; }

    public DbSet<ProfesoresXCurso> ProfesoresXCursoes { get; set; }

    public DbSet<Proyecto> Proyectos { get; set; }

    public DbSet<ProyectosXProfesor> ProyectosXProfesors { get; set; }

    public DbSet<Sede> Sedes { get; set; }

    public DbSet<Usuario> Usuarios { get; set; }

    public DbSet<Ajuste> Ajustes { get; set; }

    public DbSet<Dia> Dias { get; set; }

    public DbSet<Aula> Aulas { get; set; }

    public DbSet<BloqueAcademico> BloqueAcademicoes { get; set; }

    public DbSet<BloqueAcademicoXPlanDeEstudio> BloqueAcademicoXPlanDeEstudios { get; set; }

}

}

