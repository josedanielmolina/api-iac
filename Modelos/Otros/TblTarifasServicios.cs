using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ProyectoGenerico_SinArquitectura.Models
{
    public partial class TblTarifasServicios
    {
        public int Id { get; set; }
        public string TipoServicio { get; set; }
        public int CategoriaAño { get; set; }
        public string TipoVehiculo { get; set; }
        public string Servicio { get; set; }
        public int Tarifa { get; set; }
        public int Ansv { get; set; }
        public int Recaudo { get; set; }
        public int Runt { get; set; }
        public int Sicov { get; set; }
        public int Iva { get; set; }
        public int Ivarecaudo { get; set; }
        public int Propio { get; set; }
    }
}
