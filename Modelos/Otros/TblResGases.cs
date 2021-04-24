using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ProyectoGenerico_SinArquitectura.Models
{
    public partial class TblResGases
    {
        public int Id { get; set; }
        public string Tempmotor { get; set; }
        public string RevRalenti { get; set; }
        public string HcRalenti { get; set; }
        public string CoRalenti { get; set; }
        public string Co2Ralenti { get; set; }
        public string O2Ralenti { get; set; }
        public string RevCrucero { get; set; }
        public string HcCrucero { get; set; }
        public string CoCrucero { get; set; }
        public string Co2Crucero { get; set; }
        public string O2Crucero { get; set; }
        public string Dilucion { get; set; }
        public int Idprueba { get; set; }
        public int Escape { get; set; }
        public int Salidas { get; set; }
        public int Aceite { get; set; }
        public int Comb { get; set; }
        public int Filtro { get; set; }
        public int Recirculacion { get; set; }
        public int Sonda { get; set; }
        public int Refri { get; set; }
        public int Silenciador { get; set; }
        public int Rev { get; set; }
        public int Humo { get; set; }
        public int Estado { get; set; }
        public string Operario { get; set; }
        public string Observaciones { get; set; }
        public string Mecanizada { get; set; }
        public string IncumplimientoNiveles { get; set; }
        public string Checksum { get; set; }
        public string Ensambladora { get; set; }
        public string VersionApp { get; set; }
        public string Catalizador { get; set; }
    }
}
