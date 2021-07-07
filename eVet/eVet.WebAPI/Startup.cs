using eVet.Model.Request;
using eVet.WebAPI.Database;
using eVet.WebAPI.Filters;
using eVet.WebAPI.Security;
using eVet.WebAPI.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace eVet.WebAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddControllers().AddJsonOptions(options =>
            //{
            //    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve;
            //});
            services.AddMvc().AddNewtonsoftJson(o =>
            {
                o.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            });
            services.AddControllers(x=>x.Filters.Add<ErrorFilter>());
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "eVet API", Version = "v1" });
                c.AddSecurityDefinition("basic", new OpenApiSecurityScheme
                {
                    Name = "Authorization",
                    Type = SecuritySchemeType.Http,
                    Scheme = "basic",
                    In = ParameterLocation.Header
                });
                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                          new OpenApiSecurityScheme
                          {
                              Reference = new OpenApiReference
                              {
                                  Type = ReferenceType.SecurityScheme,
                                  Id = "basic"
                              }
                          },
                          new string[] {}
                    }
                });
            });

            services.AddAuthentication("BasicAutentication").AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAutentication", null);

            services.AddDbContext<VeterinarskaStanicaContext>(options => options.UseSqlServer(Configuration.GetConnectionString("eVet")));
            //services.AddScoped<ILjubimciService, LjubimciService>();
            services.AddScoped<IPreporukeService, PreporukeService>();
            services.AddScoped<IKorisniciService, KorisniciService>();

            services.AddScoped<IService<Model.Uloge, UlogeSearchRequest>, UlogeService>();
            services.AddScoped<ICRUDService<Model.Lijek, LijekSearchRequest, LijekUpsertRequest, LijekUpsertRequest>, LijekService>();
            services.AddScoped<ICRUDService<Model.VrstaUsluge, object, VrstaUslugeUpsertRequest, VrstaUslugeUpsertRequest>, VrstaUslugeService>();
            services.AddScoped<ICRUDService<Model.Termini, object, TerminUpsertRequest, TerminUpsertRequest>, TerminService>();
            //services.AddScoped<ICRUDService<Model.Racun, RacuniSearchRequest, RacuniInsertRequest, RacunUpdateRequest>, RacunService>();
            services.AddScoped<RacunService>();
            services.AddScoped<LjubimciService>();
            services.AddScoped<RezervacijeService>();
            services.AddScoped<PreglediService>();
            services.AddScoped<DijagnozeService>();
            services.AddAutoMapper(typeof(Startup));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "eVet API");
            });

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
