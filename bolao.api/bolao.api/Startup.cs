using bolao.api.Data;
using bolao.api.Entities;
using bolao.api.Persistence.Repository;
using bolao.api.Persistence.Repository.Interface;
using bolao.api.Repository;
using bolao.api.Repository.Interface;
using bolao.api.Service;
using bolao.api.Service.Interface;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bolao.api
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
            #region Repository
            services.AddScoped<IParticipantRepository, ParticipantRepository>();
            services.AddScoped<IEquipeRepository,EquipeRepository >();
            #endregion

            #region Service
            services.AddScoped<IParticipantService, ParticipantService>();
            services.AddScoped<IEquipeService,EquipeService>();
            #endregion
            services.AddControllers();
            
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "bolao.api", Version = "v1" });
            });

            services.AddDbContext<DataContext>(options => 
                options.UseSqlite(Configuration.GetConnectionString("myConnection")));

            //services.AddDbContext<DataContext>(options =>
            //    options.UseInMemoryDatabase("bolao"));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "bolao.api v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
