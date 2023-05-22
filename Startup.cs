using Microsoft.EntityFrameworkCore;
using CalculadoraCientifica.Data;
using CalculadoraCientifica.Models;

namespace CalculadoraCientifica
{
    public class Startup
    {
        private IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {

            services.AddDbContext<CalculadoraContext>(options =>
                options.UseSqlServer(_configuration.GetConnectionString("DefaultConnection")));

            services.AddMvc(options => options.EnableEndpointRouting = false);
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "CalculadoraCientificaRuta",
                    template: "{controller}/{action}/{id?}",
                    defaults: new { controller = "Calculadora", action = "Index" },
                    constraints: new { id = "[0-9]+" });
            });
        }
    }
}