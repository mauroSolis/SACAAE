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
