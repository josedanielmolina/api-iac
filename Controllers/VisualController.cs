namespace Controllers
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;

    using AutoMapper;

    using Modelos;
    using Repositorio;
    using Dto;
    using Microsoft.Extensions.Configuration;

    [Route("api/[controller]")]
    [ApiController]
    public class VisualController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly TblPruebasRepositorio _repositorioTblPruebas;
        private readonly TblListasPersonalizadasRepositorio _tblListasPersonalizadasRepositorio;
        private readonly TblVehiculosRepositorio _tblVehiculosRepositorio;
        private readonly DefectosRepositorio _defectosRepositorio;
        private readonly TblEquiposRepositorio _tblEquiposRepositorio;
        private readonly TblObservacionesRepositorio _tblObservacionesRepositorio;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;

        public VisualController(ApplicationDbContext context,
                                TblPruebasRepositorio repositorioTblPruebas,
                                TblListasPersonalizadasRepositorio tblListasPersonalizadasRepositorio,
                                TblVehiculosRepositorio tblVehiculosRepositorio,
                                DefectosRepositorio defectosRepositorio,
                                TblEquiposRepositorio tblEquiposRepositorio,
                                TblObservacionesRepositorio tblObservacionesRepositorio,
                                IMapper mapper,
                                IConfiguration configuration)
        {
            _context = context;
            _repositorioTblPruebas = repositorioTblPruebas;
            _tblListasPersonalizadasRepositorio = tblListasPersonalizadasRepositorio;
            _tblVehiculosRepositorio = tblVehiculosRepositorio;
            _defectosRepositorio = defectosRepositorio;
            _tblEquiposRepositorio = tblEquiposRepositorio;
            _tblObservacionesRepositorio = tblObservacionesRepositorio;
            _mapper = mapper;
            _configuration = configuration;
        }

        [HttpGet("lista-maestra")]
        public async Task<IActionResult> ConsultarListaMaestra()
        {
            try
            {
                var datos = await _context.tbl_lista_maestra.Where(x => x.Habilitado == 1).ToListAsync();

                var dto = _mapper.Map<List<ListaMaestraDto>>(datos);

                return Ok(new { dto });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Mensaje = ex.Message });
            }


        }
        
        [HttpGet("listas-personalizadas")]
        public async Task<IActionResult> ConsultarListas([FromQuery] string tipo)
        {
            try
            {
                var dto = await _tblListasPersonalizadasRepositorio.ConsultarListas(tipo);

                if (dto != null)
                {
                    return Ok(new { dto });
                }

                return StatusCode(404, new { Mensaje = "No se encontro ninguna lista personalizada" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Mensaje = ex.Message });
            }


        }

        [HttpGet("listar-placas")]
        public async Task<IActionResult> ConsultarPlacas([FromQuery] string tipo)
        {
            try
            {
                if (tipo == "motocicleta")
                {
                    var dto = await _repositorioTblPruebas.ConsultarPlacasMotocicletas();
                    return Ok(new { dto });
                }

                if (tipo == "liviano")
                {
                    var dto = await _repositorioTblPruebas.ConsultarPlacasLivianos();
                    return Ok(new { dto });
                }

                if (tipo == "pesado")
                {
                    var dto = await _repositorioTblPruebas.ConsultarPlacasPesados();
                    return Ok(new { dto });
                }

                if (tipo == "motocarro")
                {
                    var dto = await _repositorioTblPruebas.ConsultarPlacasMotocarros();
                    return Ok(new { dto });
                }


                return Ok(new { dto = "No hay placas que requieran de la prueba visual" });

            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Mensaje = ex.Message });
            }
        }

        [HttpGet("consultar-vehiculo/{idPrueba}")]
        public async Task<IActionResult> ConsultarDatosVehiculos(int idPrueba)
        {
            try
            {
                var dto = await _tblVehiculosRepositorio.ConsultarDatosVehiculo(idPrueba);
                return Ok(new { dto });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Mensaje = ex.Message });
            }
        }

        [HttpGet("listar-defectos/{tipoVehiculo}")]
        public async Task<IActionResult> ConsultarDefectos([FromRoute] string tipoVehiculo)
        {

            try
            {
                if (tipoVehiculo == "motocicleta")
                {
                    var dto = await _defectosRepositorio.ConsultarDefectosMotocicleta();
                    return Ok(new { dto });
                }

                if (tipoVehiculo == "liviano" || tipoVehiculo == "pesado")
                {
                    var dto = await _defectosRepositorio.ConsultarDefectosLivanosPesados();
                    return Ok(new { dto });
                }

                if (tipoVehiculo == "motocarro")
                {
                    var dto = await _defectosRepositorio.ConsultarDefectosMotocarro();
                    return Ok(new { dto });
                }

                return StatusCode(404, new { Mensaje = "Tipo de vehiculo no encontrado" });

            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Mensaje = ex.Message });
            }

        }

        [HttpGet("pendiente/{idTurno}")]
        public async Task<IActionResult> ConsultarPendiente([FromRoute] int idTurno)
        {
            try
            {
                var datos = await _context.tbl_prueba_visual.OrderByDescending(t => t.Id).FirstOrDefaultAsync(x => x.Idturno == idTurno && x.Pendiente == 1);

                var dto = _mapper.Map<PruebaVisualDto>(datos);

                if (dto == null)
                {
                    return Ok(new { Pendiente = false });
                }

                return Ok(new { Pendiente = true, dto });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Mensaje = ex.Message });
            }

        }

        [HttpGet("configuracion-lista/{nombreLista}")]
        public async Task<IActionResult> ConsultarConfiguracionLista([FromRoute] string nombreLista)
        {
            try
            {
                var dto = await _tblListasPersonalizadasRepositorio.ConsultarConfiguracionLista(nombreLista);
                return Ok(new { dto });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Mensaje = ex.Message });
            }

        }

        [HttpGet("profundimetros")]
        public async Task<IActionResult> ListarProfundimetros()
        {
            try
            {
                var dto = await _tblEquiposRepositorio.ListarProfundimetros();
                return Ok(new { dto });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Mensaje = ex.Message });
            }

        }

        [HttpGet("listar-observaciones")]
        public async Task<IActionResult> ListarObservaciones()
        {
            try
            {
                var dto = await _tblObservacionesRepositorio.ListarObservaciones();
                return Ok(new { dto });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Mensaje = ex.Message });
            }

        }

        [HttpPost("registrar-pendiente")]
        public async Task<IActionResult> RegistrarPruebaPendiente(PruebaVisualDto pruebaVisual)
        {

            try
            {
                var prueba = _mapper.Map<TblPruebaVisual>(pruebaVisual);
                prueba.Fecha = DateTime.Now;

                _context.Add(prueba);
                await _context.SaveChangesAsync();

                return Ok(new { Mensaje = "La prueba ha quedado en estado pendiente" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Mensaje = ex.Message });
            }

        }

        [HttpPost("actualizar-pendiente")]
        public async Task<IActionResult> ActualizarPruebaPendiente(PruebaVisualDto pruebaVisualDto)
        {

            try
            {
                var prueba = await _context.tbl_prueba_visual.OrderByDescending(t => t.Id).FirstOrDefaultAsync(x => x.Idturno == pruebaVisualDto.Idturno && x.Pendiente == 1);

                if (prueba == null)
                {
                    return StatusCode(404, new { Mensaje = "La prueba que intenta actualizar no existe" });
                }

                prueba = _mapper.Map(pruebaVisualDto, prueba);
                prueba.Fecha = DateTime.Now;

                await _context.SaveChangesAsync();

                return Ok(new { Mensaje = "La prueba ha quedado en estado pendiente" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Mensaje = ex.Message });
            }

        }

        [HttpPost("finalizar-prueba")]
        public async Task<IActionResult> FinalizarPrueba(ResultadoDto resultado, string accion)
        {
            try
            {
               
                var pruebäPendiente = await _context.tbl_prueba_visual.OrderByDescending(t => t.Id).FirstOrDefaultAsync(x => x.Idturno == resultado.PruebaVisual.Idturno && x.Pendiente == 1);

                // Encoding de la firma de base64 a Jpeg
                var encodedImage = resultado.PruebaVisual.Firma.Split(",")[1];
                var decodedImage = Convert.FromBase64String(encodedImage);

                // Si tiene una prueba pendiente se actualiza y finaliza
                if (pruebäPendiente != null)
                {
                    var actualizarPrueba = _mapper.Map(resultado.PruebaVisual, pruebäPendiente);
                    actualizarPrueba.Fecha = DateTime.Now;
                    actualizarPrueba.Firma = decodedImage;
                }
                else
                {
                    // Si no tiene una prueba pendiente se finaliza
                    var pruebaNueva = _mapper.Map<TblPruebaVisual>(resultado.PruebaVisual);
                    pruebaNueva.Fecha = DateTime.Now;
                    pruebaNueva.Firma = decodedImage;
                    _context.Add(pruebaNueva);

                }

                // Cambiamos el estado del campo visual de la tabla pruebas 
                var tablaPrueba = await _context.tbl_pruebas.FirstOrDefaultAsync(x => x.Id == resultado.PruebaVisual.Idturno);
                tablaPrueba.Visual = 1;

                // Guardar resultados en la tabla auditoria sicov
                var profundimetro =await _context.tbl_equipos.FirstOrDefaultAsync(x => x.Id == resultado.PruebaVisual.Equipo);
                var ipEquipo = _configuration["ipEquipo"];
                var tipoOperacion = _configuration["tipoOperacion"];
                var tipoEvento = _configuration["tipoEvento"];
                var codigoProveedor = _configuration["codigoProveedor"];
                var idRuntCda = _configuration["idRuntCda"];
                var fechaActual = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff");

                var registroAuditorioSicov = new TblAuditoriaSicov();
                registroAuditorioSicov.Id_Revision = resultado.VisualSicov.Id_Revision;
                registroAuditorioSicov.Serial_Equipo_Medicion = profundimetro.Serial;
                registroAuditorioSicov.Ip_Equipo_Medicion = ipEquipo;
                registroAuditorioSicov.Fecha_Registro_Bd = fechaActual;
                registroAuditorioSicov.Fecha_Evento = fechaActual;
                registroAuditorioSicov.Tipo_Operacion = Convert.ToInt32(tipoOperacion);
                registroAuditorioSicov.Tipo_Evento = Convert.ToInt32(tipoEvento);
                registroAuditorioSicov.Codigo_Proveedor = Convert.ToInt32(codigoProveedor);
                registroAuditorioSicov.Id_Runt_Cda = Convert.ToInt32(idRuntCda);
                registroAuditorioSicov.Trama = resultado.VisualSicov.Trama;
                registroAuditorioSicov.Identificacion_Usuario = resultado.VisualSicov.Identificacion_Usuario;
                registroAuditorioSicov.Observacion = "";
                registroAuditorioSicov.Placa = resultado.VisualSicov.Placa;

                _context.tbl_auditoria_sicov.Add(registroAuditorioSicov);


                // Guardamos todos los cambios
                await _context.SaveChangesAsync();

                return Ok(new { resultado, Mensaje = "Prueba finalizada exitosamente" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Mensaje = ex });
            }


        }


    }
}
