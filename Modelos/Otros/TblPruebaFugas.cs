using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ProyectoGenerico_SinArquitectura.Models
{
    public partial class TblPruebaFugas
    {
        public int Id { get; set; }
        public string Resultado { get; set; }
        public string Valor { get; set; }
        public string Responsable { get; set; }
        public int IdOrganizacion { get; set; }
        public string Prueba { get; set; }
        public int IdAnalizador { get; set; }
    }
}
