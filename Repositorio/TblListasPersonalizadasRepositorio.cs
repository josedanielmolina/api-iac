namespace Repositorio
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using System.Linq;
    using Microsoft.EntityFrameworkCore;

    using Modelos;
    using Dto;
    using System.Text.Json;

    public class TblListasPersonalizadasRepositorio
    {
        private readonly ApplicationDbContext _context;

        public TblListasPersonalizadasRepositorio(ApplicationDbContext context)
        {
            _context = context;
        }


        public async Task<List<ListaPersonalizadaDto>> ConsultarListas(string tipo)
        {
            var dto = await (from listas in _context.tbl_listas_personalizadas
                               where listas.Tipo == tipo
                               select new ListaPersonalizadaDto
                               {
                                   Llave = listas.Nombre,
                                   Valor = listas.NombreCorto
                               }).ToListAsync();



            return dto;
        }

        public async Task<ConfiguracionListaDto> ConsultarConfiguracionLista(string lista)
        {
            var datos = await _context.tbl_listas_personalizadas.FirstOrDefaultAsync(x => x.NombreCorto == lista);
            var configuracion = new ConfiguracionListaDto() 
            {
                Configuracion = datos.Configuracion,
                Equipo = datos.Equipo,
                Equipo2 = datos.Equipo2,
            };

            return configuracion;
        }
    }
}
