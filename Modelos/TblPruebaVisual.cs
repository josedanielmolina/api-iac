namespace Modelos
{
    using System;

    public partial class TblPruebaVisual
    {
        public int Id { get; set; }
        public int Idturno { get; set; }
        public int Idplaca { get; set; }
        public string Categorias { get; set; }
        public int Totala { get; set; }
        public int Operario { get; set; }
        public DateTime Fecha { get; set; }
        public int Totalb { get; set; }
        public string Observaciones { get; set; }
        public string Obs_Texto { get; set; }
        public int Equipo { get; set; }
        public string Prof_Eje1_Izq { get; set; }
        public string Prof_Eje1_Der { get; set; }
        public string Prof_Eje2_Izq_Ext { get; set; }
        public string Prof_Eje2_Izq_Int { get; set; }
        public string Prof_Eje2_Der_Ext { get; set; }
        public string Prof_Eje2_Der_Int { get; set; }
        public string Prof_Eje3_Izq_Ext { get; set; }
        public string Prof_Eje3_Izq_Int { get; set; }
        public string Prof_Eje3_Der_Ext { get; set; }
        public string Prof_Eje3_Der_Int { get; set; }
        public string Prof_Eje4_Izq_Ext { get; set; }
        public string Prof_Eje4_Izq_Int { get; set; }
        public string Prof_Eje4_Der_Ext { get; set; }
        public string Prof_Eje4_Der_Int { get; set; }
        public string Prof_Eje5_Izq_Ext { get; set; }
        public string Prof_Eje5_Izq_Int { get; set; }
        public string Prof_Eje5_Der_Ext { get; set; }
        public string Prof_Eje5_Der_Int { get; set; }
        public string Prof_Repuesto1 { get; set; }
        public string Prof_Repuesto2 { get; set; }
        public int Falla_Prof { get; set; }
        public byte[] Firma { get; set; }
        public string CodigosNoAplican { get; set; }
        public string VersionApp { get; set; }
        public int Equipo2 { get; set; }
        public int Pendiente { get; set; }
    }
}
