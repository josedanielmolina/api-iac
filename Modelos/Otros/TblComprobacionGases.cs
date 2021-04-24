using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ProyectoGenerico_SinArquitectura.Models
{
    public partial class TblComprobacionGases
    {
        public int Id { get; set; }
        public string Hclow { get; set; }
        public string ActualHclow { get; set; }
        public string Colow { get; set; }
        public string ActualColow { get; set; }
        public string Co2low { get; set; }
        public string ActualCo2low { get; set; }
        public string O2low { get; set; }
        public string ActualO2low { get; set; }
        public string Hchigh { get; set; }
        public string ActualHchigh { get; set; }
        public string Cohigh { get; set; }
        public string ActualCohigh { get; set; }
        public string Co2high { get; set; }
        public string ActualCo2high { get; set; }
        public string O2high { get; set; }
        public string ActualO2high { get; set; }
        public string IdAnalizador { get; set; }
        public string Pef { get; set; }
        public string IdOrganizacion { get; set; }
        public string Prueba { get; set; }
        public string Resultado { get; set; }
        public string Responsable { get; set; }
    }
}
