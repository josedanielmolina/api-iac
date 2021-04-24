namespace Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using System.Threading.Tasks;

    using Modelos;
    using Dto;
    using System.Collections.Generic;
    using System.Security.Claims;
    using System.IdentityModel.Tokens.Jwt;
    using System;
    using Microsoft.IdentityModel.Tokens;
    using Microsoft.Extensions.Configuration;
    using System.Text;

    [Route("api/[controller]")]
    [ApiController]
    public class AutorizacionController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IConfiguration _configuration;

        public AutorizacionController(ApplicationDbContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] CredencialesDto credencialesDto)
        {
            var usuario = await _context.tbl_usuarios.FirstOrDefaultAsync(x => x.Usuario == credencialesDto.usuario);

            if (usuario == null)
            {
                return StatusCode(400, new { Mensaje = "Usuario o Contraseña incorrecto" });
            }

            if (usuario.Pass != credencialesDto.contrasena)
            {
                return StatusCode(400, new { Mensaje = "Usuario o Contraseña incorrecto" });
            }

            if (usuario.Habilitado == 0)
            {
                return StatusCode(400, new { Mensaje = "Usuario inhabilitado, pongase en contacto con el administrador del sistema" });
            }

            if (usuario.Nivel == 1 )
            {
                return StatusCode(400, new { Mensaje = "No posee el nivel de autorizacion para ingresar a este modulo" });
            }    
           

            var claims = new List<Claim>
            {
                new Claim("id", usuario.Id.ToString()),
                new Claim("nombre", usuario.Nombres),
                new Claim("identificacion", usuario.Cedula),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(ClaimTypes.Role, usuario.Nivel.ToString())
            };




            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["jwt"]));
            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var expires = DateTime.UtcNow.AddMinutes(60); // Tiempo de expiracion

            var jwtToken = new JwtSecurityToken(
               issuer: null,
               audience: null,
               claims: claims,
               expires: expires,
               signingCredentials: credentials);

            var token = new JwtSecurityTokenHandler().WriteToken(jwtToken);

            TokenDto autorizacion = new TokenDto();
            autorizacion.Token = token;
            autorizacion.Expiration = expires;

            return Ok(new { Autorizacion = autorizacion });

        }
    }
}
