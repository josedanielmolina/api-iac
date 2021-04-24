using System;

namespace Modelos
{
    public partial class TblVehiculos
    {
        public int Id { get; set; }
        public string Propietario { get; set; }
        public string placa { get; set; }
        public string Marca { get; set; }
        public string Linea { get; set; }
        public string Clase { get; set; }
        public string Servicio { get; set; }
        public string Cilindraje { get; set; }
        public int Numeroejes { get; set; }
        public int Combustible { get; set; }
        public string Serialdelmotor { get; set; }
        public string Numero { get; set; }
        public string Numerolicencia { get; set; }
        public string Departamento { get; set; }
        public string Ciudad { get; set; }
        public string Llanta { get; set; }
        public string Diametrollanta { get; set; }
        public string Tipollanta { get; set; }
        public string Color { get; set; }
        public string Soat { get; set; }
        public DateTime Fechaexpedicion { get; set; }
        public DateTime Fechaexpiracion { get; set; }
        public string Aseguradora { get; set; }
        public int Modelo { get; set; }
        public int? Liviano { get; set; }
        public int? Tipo { get; set; }
        public string Codmun { get; set; }
        public string Coddep { get; set; }
        public string Codlinea { get; set; }
        public string Codmarca { get; set; }
        public string Codcolor { get; set; }
        public int Codespecial { get; set; }
        public string Codclase { get; set; }
        public int? Tiemposmotor { get; set; }
        public string Idaseguradora { get; set; }
        public bool Taximetro { get; set; }
        public int Cilindros { get; set; }
        public string Chasis { get; set; }
        public string Num_Sillas { get; set; }
        public string Polarizados { get; set; }
        public string Blindaje { get; set; }
        public string Pais { get; set; }
        public string Kilometraje { get; set; }
        public string Escape { get; set; }
        public string Empresa { get; set; }
        public string ModificacionesMotor { get; set; }
        public string PotenciaMotor { get; set; }
        public string Diseño { get; set; }
        public string ConvertidoGnv { get; set; }
        public DateTime VencimientoGnv { get; set; }
        public string PesoBruto { get; set; }
    }
}
