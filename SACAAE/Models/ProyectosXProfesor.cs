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
    
    public partial class ProyectosXProfesor
    {
        public int ID { get; set; }
        public int Proyecto { get; set; }
        public int Profesor { get; set; }
        public int Periodo { get; set; }
        public Nullable<int> Horario { get; set; }
    
        public virtual Horario Horario1 { get; set; }
        public virtual Periodo Periodo1 { get; set; }
        public virtual Proyecto Proyecto1 { get; set; }
        public virtual Profesore Profesore { get; set; }
    }
}
