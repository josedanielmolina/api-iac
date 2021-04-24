using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ProyectoGenerico_SinArquitectura.Models
{
    public partial class TblRegistroDefectosEstver
    {
        public int Id { get; set; }
        public string Linea { get; set; }
        public string ClaseVehiculo { get; set; }
        public string Estacion { get; set; }
        public string Equipo { get; set; }
        public string Defecto { get; set; }
        public string Causa { get; set; }
        public string Correccion { get; set; }
        public string Inspector { get; set; }
        public string Reviso { get; set; }
        public string Comentarios { get; set; }
    }
}
