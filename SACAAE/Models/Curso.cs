
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
    
public partial class Curso
{

    public Curso()
    {

        this.BloqueXPlanXCursoes = new HashSet<BloqueXPlanXCurso>();

        this.CursosXGrupoes = new HashSet<CursosXGrupo>();

    }


    public int ID { get; set; }

    public string Nombre { get; set; }

    public string Codigo { get; set; }

    public int HorasTeoricas { get; set; }

    public int Bloque { get; set; }

    public bool Externo { get; set; }

    public Nullable<int> HorasPracticas { get; set; }



    public virtual ICollection<BloqueXPlanXCurso> BloqueXPlanXCursoes { get; set; }

    public virtual ICollection<CursosXGrupo> CursosXGrupoes { get; set; }

}

}
