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
    
    public partial class PlazaXProfesor
    {
        public int ID { get; set; }
        public int Plaza { get; set; }
        public int Profesor { get; set; }
        public Nullable<int> Horas_Asignadas { get; set; }
    
        public virtual Plaza Plaza1 { get; set; }
        public virtual Profesore Profesore { get; set; }
    }
}
