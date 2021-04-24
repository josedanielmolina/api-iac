using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ProyectoGenerico_SinArquitectura.Models
{
    public partial class TblResOpacidad
    {
        public int Id { get; set; }
        public int IdPrueba { get; set; }
        public int FuncionaRevMotor { get; set; }
        public string Rpmgobernada { get; set; }
        public string TempAceite { get; set; }
        public string Rpmralenti { get; set; }
        public string OpaPreliminar { get; set; }
        public string Rpmpreliminar { get; set; }
        public string OpaCiclo1 { get; set; }
        public string Rpmciclo1 { get; set; }
        public string OpaCiclo2 { get; set; }
        public string Rpmciclo2 { get; set; }
        public string OpaCiclo3 { get; set; }
        public string Rpmciclo3 { get; set; }
        public string OpaProm { get; set; }
        public string Ltoe { get; set; }
        public string TempFinalAceite { get; set; }
        public int Fugas { get; set; }
        public int FiltroAire { get; set; }
        public int TapaComb { get; set; }
        public int TapaAceite { get; set; }
        public int ConexionSonda { get; set; }
        public int SalidasAdicionales { get; set; }
        public int Dispositivos { get; set; }
        public int SistRefrigeracion { get; set; }
        public int RevInestables { get; set; }
        public int CausaRechazo { get; set; }
        public int Valida5s { get; set; }
        public int Validavar { get; set; }
        public int Validatemp { get; set; }
        public int Valida2p { get; set; }
        public string Operario { get; set; }
        public int Estado { get; set; }
        public string Observaciones { get; set; }
        public string IndVisSonMal { get; set; }
        public string EstabilidadCiclos { get; set; }
        public string FallaSubita { get; set; }
        public string IncumplimientoNiveles { get; set; }
        public string Mecanizada { get; set; }
        public int FugasSilenciador { get; set; }
        public string Checksum { get; set; }
        public string VersionApp { get; set; }
        public byte Ensambladora { get; set; }
    }
}
