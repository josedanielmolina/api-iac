
namespace Repositorio
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using System.Linq;
    using Microsoft.EntityFrameworkCore;

    using Modelos;
    using Dto;

    public class TblPruebasRepositorio
    {
        private readonly ApplicationDbContext _context;

        public TblPruebasRepositorio(ApplicationDbContext context)
        {
            _context = context;
        }


        public async Task<List<PlacaDto>> ConsultarPlacasMotocicletas()
        {
            var dto = await (from pruebas in _context.tbl_pruebas
                             join vehiculos in _context.tbl_vehiculos on pruebas.Idplaca equals vehiculos.Id
                             where pruebas.Estado == 0
                             where pruebas.Linea == 2
                             where pruebas.Visual == 0
                             select new PlacaDto
                             {
                                 IdPrueba = pruebas.Id,
                                 Placa = vehiculos.placa
                             }).ToListAsync();

            return dto;
        }

        public async Task<List<PlacaDto>> ConsultarPlacasLivianos()
        {
            var dto = await (from pruebas in _context.tbl_pruebas
                             join vehiculos in _context.tbl_vehiculos on pruebas.Idplaca equals vehiculos.Id
                             where pruebas.Estado == 0
                             where pruebas.Linea == 1
                             where pruebas.Visual == 0
                             where vehiculos.Liviano == 1
                             where vehiculos.Clase != "MOTOCARRO"
                             select new PlacaDto
                             {
                                 IdPrueba = pruebas.Id,
                                 Placa = vehiculos.placa
                             }).ToListAsync();

            return dto;
        }

        public async Task<List<PlacaDto>> ConsultarPlacasPesados()
        {
            var dto = await (from pruebas in _context.tbl_pruebas
                             join vehiculos in _context.tbl_vehiculos on pruebas.Idplaca equals vehiculos.Id
                             where pruebas.Estado == 0
                             where pruebas.Linea == 1
                             where vehiculos.Liviano == 0
                             where pruebas.Visual == 0
                             select new PlacaDto
                             {
                                 IdPrueba = pruebas.Id,
                                 Placa = vehiculos.placa
                             }).ToListAsync();

            return dto;
        }

        public async Task<List<PlacaDto>> ConsultarPlacasMotocarros()
        {
            var dto = await (from pruebas in _context.tbl_pruebas
                             join vehiculos in _context.tbl_vehiculos on pruebas.Idplaca equals vehiculos.Id
                             where pruebas.Estado == 0
                             where vehiculos.Clase == "MOTOCARRO"
                             where pruebas.Visual == 0
                             select new PlacaDto
                             {
                                 IdPrueba = pruebas.Id,
                                 Placa = vehiculos.placa
                             }).ToListAsync();

            return dto;
        }


    }
}
