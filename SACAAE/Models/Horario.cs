
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
    using System.Collections.Generic;
    
public partial class Horario
{

    public Horario()
    {

        this.ComisionesXProfesors = new HashSet<ComisionesXProfesor>();

        this.Detalle_Curso = new HashSet<Detalle_Curso>();

        this.ProyectosXProfesors = new HashSet<ProyectosXProfesor>();

        this.Dias = new HashSet<Dia>();

    }


    public int Id { get; set; }



    public virtual ICollection<ComisionesXProfesor> ComisionesXProfesors { get; set; }

    public virtual ICollection<Detalle_Curso> Detalle_Curso { get; set; }

    public virtual ICollection<ProyectosXProfesor> ProyectosXProfesors { get; set; }

    public virtual ICollection<Dia> Dias { get; set; }

}

}
