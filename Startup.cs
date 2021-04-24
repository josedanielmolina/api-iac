namespace Api
{
    using System.Text;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;
    using Microsoft.IdentityModel.Tokens;
    using Microsoft.OpenApi.Models;
    using Microsoft.EntityFrameworkCore;

    using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

    using Microsoft.AspNetCore.Authentication.JwtBearer;

    using Modelos;
    using Configuraciones;
    using System;

    public class Startup
    {

        /* Propiedades */
        public IConfiguration Configuration { get; }

        /* Constructor */
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        /* Servicios */
        public void ConfigureServices(IServiceCollection services)
        {
            // Configuracion de CORS
            services.AddCors(options =>
            {
                var frontendURL = Configuration.GetValue<string>("frontend_url");
                options.AddDefaultPolicy(builder =>
                {
                    builder.WithOrigins(frontendURL).AllowAnyMethod().AllowAnyHeader();
                });
            });


            // Pascal casing
            services.AddControllersWithViews().
                    AddJsonOptions(options =>
                    {
                        options.JsonSerializerOptions.PropertyNameCaseInsensitive = true;
                        options.JsonSerializerOptions.PropertyNamingPolicy = null;
                    });


            // Registrar los servicios de inyeccion de dependencias
            services.RegisterServices(Configuration);

            //Configuracion de base de datos
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseMySQL(Configuration.GetConnectionString("DefaultConection"));


            });

            //services.AddDbContext<ApplicationDbContext>(
            //        options => options.UseMySql(Configuration.GetConnectionString("DefaultConection"),

            //     mySqlOptions =>
            //         {
            //             mySqlOptions.ServerVersion(new Version(5, 7, 34), ServerType.MySql)
            //             .EnableRetryOnFailure(
            //                  maxRetryCount: 10,
            //             maxRetryDelay: TimeSpan.FromSeconds(30),
            //                 errorNumbersToAdd: null);
            //         }
            //    ));

            //Configuracion AutoMapper
            services.AddAutoMapper(typeof(Startup));

            // Configuracion JWT
            JwtConfigurar(services);

            // Configuracion Seguridad y Roles
            Seguridad(services);

            // Configuracion Swagger
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Lab v1", Version = "v1" });
            });

            //services.AddControllers().AddNewtonsoftJson(options => options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);


        }

        /* Middlewares */
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Lab v1"));
            }

            app.UseCors();
            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

        /* Metodos Privados */
        private void JwtConfigurar(IServiceCollection services)
        {
            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(x =>
            {
                x.RequireHttpsMetadata = false;
                x.SaveToken = true;
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["jwt"])),
                    ValidateIssuer = false,
                    ValidateAudience = false
                };
            });


        }

        private void Seguridad(IServiceCollection services)
        {
            services.AddAuthorization(options =>
                                options.AddPolicy("Admin",
                                policy => policy.RequireRole("admin", "usuario")));
        }


    }
}
