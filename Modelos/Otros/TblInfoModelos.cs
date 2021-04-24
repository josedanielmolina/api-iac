using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ProyectoGenerico_SinArquitectura.Models
{
    public partial class TblInfoModelos
    {
        public int Id { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public string Ean { get; set; }
        public string Cilindraje { get; set; }
        public string Marca { get; set; }
        public string Clase { get; set; }
        public string Escape { get; set; }
        public string Diseno { get; set; }
    }
}
