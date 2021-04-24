using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ProyectoGenerico_SinArquitectura.Models
{
    public partial class TblEventosSicov
    {
        public int Id { get; set; }
        public string FechaEvento { get; set; }
        public string NombrePrueba { get; set; }
        public string PlacaVehiculo { get; set; }
        public string SerialEquipo { get; set; }
        public int IdEvento { get; set; }
        public string MsgEvento { get; set; }
        public int StatusEvento { get; set; }
    }
}
