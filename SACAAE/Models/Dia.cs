
//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------


namespace SACAAE.Models
{

using System;
    using System.Collections.Generic;
    
public partial class Dia
{

    public int Id { get; set; }

    public string Dia1 { get; set; }

    public int Horario { get; set; }

    public Nullable<int> Hora_Inicio { get; set; }

    public Nullable<int> Hora_Fin { get; set; }



    public virtual Horario Horario1 { get; set; }

}

}
