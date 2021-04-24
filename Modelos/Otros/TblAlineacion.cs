using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ProyectoGenerico_SinArquitectura.Models
{
    public partial class TblAlineacion
    {
        public int Id { get; set; }
        public int Idturno { get; set; }
        public int Idplaca { get; set; }
        public string Eje1 { get; set; }
        public string Eje2 { get; set; }
        public string Eje3 { get; set; }
        public string Eje4 { get; set; }
        public string Eje5 { get; set; }
        public int Operario { get; set; }
        public int Equipo { get; set; }
        public string Mecanizada { get; set; }
        public string Checksum { get; set; }
        public string VersionApp { get; set; }
    }
}
