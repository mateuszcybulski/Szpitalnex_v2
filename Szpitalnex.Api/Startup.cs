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
using Szpitalnex.Core.Models;
using Szpitalnex.Database.Repositories;
using Szpitalnex.Database.Repositories.Base.Interfaces;
using Szpitalnex.Database.Repositories.Interfaces;

namespace Szpitalnex.Api
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
            services.AddDbContext<SzpitalnexContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("SzpitalnexDatabase")));

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Szpitalnex.Api", Version = "v1" });
            });

            services.AddTransient<IDoctorRepository, DoctorRepository>();
            services.AddTransient<ISpecializationRepository, SpecializationRepository>();
            services.AddTransient<IVisitRepository, VisitRepository>();
            services.AddTransient<IDiseaseRepository, DiseaseRepository>();
            services.AddTransient<IDiagnosedDiseaseRepository, DiagnosedDiseaseRepository>();
            services.AddTransient<IReferralRepository, ReferralRepository>();
            services.AddTransient<IMedicineRepository, MedicineRepository>();
            services.AddTransient<IPrescribedMedicineRepository, PrescribedMedicineRepository>();
            services.AddTransient<IPatientRepository, PatientRepository>();
            services.AddTransient<IDoctorAvailabilityRepository, DoctorAvailabilityRepository>();
            services.AddTransient<IPersonRepository, PersonRepository>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Szpitalnex.Api v1"));
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
