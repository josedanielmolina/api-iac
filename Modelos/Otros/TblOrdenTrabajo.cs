using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ProyectoGenerico_SinArquitectura.Models
{
    public partial class TblOrdenTrabajo
    {
        public int Id { get; set; }
        public int Estado { get; set; }
        public string Placa { get; set; }
        public string Visita { get; set; }
        public string Tipo { get; set; }
        public string Combustible { get; set; }
        public string TipoTransporte { get; set; }
        public string RadioAccion { get; set; }
        public string Kilometraje { get; set; }
        public string Sillas { get; set; }
        public byte[] OrdenTrabajo { get; set; }
        public string Cumple { get; set; }
    }
}
