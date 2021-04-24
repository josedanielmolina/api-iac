using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ProyectoGenerico_SinArquitectura.Models
{
    public partial class TblSuspension
    {
        public int Id { get; set; }
        public int Idplaca { get; set; }
        public int Idturno { get; set; }
        public string Izqdelantera { get; set; }
        public string Derdelantera { get; set; }
        public string Izqtrasera { get; set; }
        public string Dertrasera { get; set; }
        public int Operario { get; set; }
        public int Equipo { get; set; }
        public string Mecanizada { get; set; }
        public string Checksum { get; set; }
        public string VersionApp { get; set; }
    }
}
