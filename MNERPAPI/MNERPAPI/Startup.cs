using DBModel;
using DBModel.Infrastruce;
using DBModel.IRepository;
using DBModel.Services;
using DBModel.Utility;
using FINANS.Infrastruct;
using FINANS.IRepository;
using FINANS.Repository;
using FINANS.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;


namespace MNERPAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {

            services.AddOptions();
            JsonSerializerSettings jsonSettings = new JsonSerializerSettings()
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
             
            };
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "MNERPAPI", Version = "v1" });
            });
            services.ConfigureMapping();
            services.AddScoped<IANAROLLERRepository, ANAROLLERRepository>();
            services.AddScoped<IANAROLLERServices, ANAROLLERServices>(); 
            
            services.AddScoped<ICARIKARTRepository, CARIKARTRepository>();
            services.AddScoped<ICARIKARTServices, CARIKARTServices>();
            
            services.AddScoped<IATTRIBUTESRepository, ATTRIBUTESRepository>();
            services.AddScoped<IATTRIBUTESServices, ATTRIBUTESServices>();
            
            services.AddScoped<IATTRIBUTESVALUERepository, ATTRIBUTESVALUERepository>();
            services.AddScoped<IATTRIBUTESVALUEServices, ATTRIBUTESVALUEServices>();

            services.AddScoped<IBANKALARRepository, BANKALARRepository>();
            services.AddScoped<IBANKALARServices, BANKALARServices>();

            services.AddScoped<ICARIHAREKETRepository, CARIHAREKETRepository>();
            services.AddScoped<ICARIHAREKETServices, CARIHAREKETServices>();
            services.AddScoped<IFISLERRepository, FISLERRepository>();
            services.AddScoped<IFISLERServices, FISLERServices>();
            services.AddScoped<ICARIFISService, CARIFISService>();
            services.AddScoped<ICARIFISRepository, CARIFISRepository>();
            services.AddScoped<ICARIGRUPLARRepository, CARIGRUPLARRepository>();
            services.AddScoped<ICARIGRUPLARServices, CARIGRUPLARServices>();
            services.AddScoped<IUSERSRepository, USERSRepository>();
            services.AddScoped<IUSERSServices, USERSServices>();
            services.AddScoped<IHelper, Helper>();
            services.AddScoped<ICARIKARTRepository, CARIKARTRepository>();
            services.AddScoped<ICARIKARTServices,   CARIKARTServices>(); 
            services.AddScoped<IPlasiyerlerRepository, PlasiyerlerRepository>();
            services.AddScoped<IPlasiyerlerServices, PlasiyerlerServices>();

            services.AddCors(options =>
            {
                options.AddPolicy("AllowAnyCorsPolicy", policy => policy.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());
            });
            services.AddControllers();
            services
                .AddMvc()
                .AddJsonOptions(opt => opt.JsonSerializerOptions.PropertyNamingPolicy = null);
            services.AddMvc(option => option.EnableEndpointRouting = false);
    

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "MNERPAPI v1"));
            }
            
            CultureInfo culture = (CultureInfo)CultureInfo.CurrentCulture.Clone();
            var dateformat = new DateTimeFormatInfo
            {
                ShortDatePattern = "dd.MM.yyyy",
                LongDatePattern = "dd.MM.yyyy hh:MM:ss"
            };

            culture.DateTimeFormat = dateformat;
            app.UseRouting();
            app.UseCors("AllowAnyCorsPolicy");
            app.UseAuthorization();

         
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });        
        }
    }
}
