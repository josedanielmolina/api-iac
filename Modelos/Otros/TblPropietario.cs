using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ProyectoGenerico_SinArquitectura.Models
{
    public partial class TblPropietario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string TipoDoc { get; set; }
        public string NumDoc { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Departamento { get; set; }
        public string Ciudad { get; set; }
    }
}
