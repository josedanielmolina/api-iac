using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ProyectoGenerico_SinArquitectura.Models
{
    public partial class TblDatosAdicionales
    {
        public int Id { get; set; }
        public int Idprueba { get; set; }
        public string Conductor { get; set; }
        public string Placa { get; set; }
        public string PoseeRtm { get; set; }
        public string CdaRtm { get; set; }
        public string FechaRtm { get; set; }
        public string ClaseVehiculo { get; set; }
        public string Combustible { get; set; }
        public string Aprobado { get; set; }
        public string Inmovilizado { get; set; }
        public string Comparendo { get; set; }
    }
}
