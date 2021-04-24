namespace Repositorio
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using System.Linq;
    using Microsoft.EntityFrameworkCore;

    using Modelos;
    using Dto;

    public class TblVehiculosRepositorio
    {
        private readonly ApplicationDbContext _context;

        public TblVehiculosRepositorio(ApplicationDbContext context)
        {
            _context = context;
        }
        
        public async Task<DatosVehiculoDto> ConsultarDatosVehiculo(int idPrueba)
        {

            var dto = await (from vehiculos in _context.tbl_vehiculos
                             join pruebas in _context.tbl_pruebas on vehiculos.Id equals pruebas.Idplaca
                             //where pruebas.Estado == 0
                             where pruebas.Id == idPrueba
                             select new DatosVehiculoDto
                             {
                                 Placa = vehiculos.placa,
                                 Clase = vehiculos.Clase,
                                 Color = vehiculos.Color,
                                 Sillas = vehiculos.Num_Sillas,
                                 NumeroEjes = vehiculos.Numeroejes,
                                 Modelo = vehiculos.Modelo,
                                 IdPlaca = pruebas.Idplaca,
                                 IdTurno = pruebas.Id,
                                 Id = pruebas.Id,
                                 PesoBruto = vehiculos.PesoBruto

                             }).FirstOrDefaultAsync();

            return dto;
        }

    }
}
