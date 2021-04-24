using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ProyectoGenerico_SinArquitectura.Models
{
    public partial class TblEntidadAmbiental
    {
        public int Id { get; set; }
        public string NumEstablecimiento { get; set; }
        public string NomEstablecimiento { get; set; }
        public string Nit { get; set; }
        public string Direccion { get; set; }
        public string Telefono1 { get; set; }
        public string Telefono2 { get; set; }
        public string Departamento { get; set; }
        public string Ciudad { get; set; }
        public string NumResolucion { get; set; }
        public string FechaResolucion { get; set; }
        public string CodigoActivacion { get; set; }
        public string ActualizacionRes { get; set; }
        public string Profesional { get; set; }
        public string Email { get; set; }
        public string CodAcreditacionCda { get; set; }
        public string IdRuntcda { get; set; }
        public string UrlSicov { get; set; }
        public string ProveedorSicov { get; set; }
        public string VectorIndra { get; set; }
        public string LlaveIndra { get; set; }
        public string UrlCi2 { get; set; }
        public string UsuarioCi2 { get; set; }
        public string ClaveCi2 { get; set; }
    }
}
