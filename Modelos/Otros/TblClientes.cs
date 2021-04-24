using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ProyectoGenerico_SinArquitectura.Models
{
    public partial class TblClientes
    {
        public int Id { get; set; }
        public string Documento { get; set; }
        public int Tipodoc { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Telefono1 { get; set; }
        public string Telefono2 { get; set; }
        public string Direccion { get; set; }
        public string Departamento { get; set; }
        public string Ciudad { get; set; }
        public string Codmun { get; set; }
        public string Coddep { get; set; }
        public string Documentop { get; set; }
        public int? Tipodocp { get; set; }
        public string Nombresp { get; set; }
        public string Apellidosp { get; set; }
        public string Telefono1p { get; set; }
        public string Telefono2p { get; set; }
        public string Direccionp { get; set; }
        public string Codmunp { get; set; }
        public string Coddepp { get; set; }
        public string Licencia { get; set; }
        public string Catlicencia { get; set; }
        public string Emailprop { get; set; }
        public string Emailcond { get; set; }
    }
}
