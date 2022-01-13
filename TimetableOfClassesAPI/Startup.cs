using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Microsoft.EntityFrameworkCore;

using TimetableOfClasses.Infrastructure.Repository;
using TimetableOfClasses.Infrastructure.Repository.impl;

namespace TimetableOfClasses.API
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

            services.AddCors(policy =>
            {
                policy.AddPolicy("CorsPolicy", opt => opt
                    .AllowAnyOrigin()
                    .AllowAnyHeader()
                    .AllowAnyMethod());
            });

            services.AddControllers();

            services.AddDbContext<TimetableOfClasses.Infrastructure.Context>(options => options.UseSqlServer(Configuration.GetConnectionString("TimetableOfClasses")));

            services.AddScoped<ILecturerRepository, LecturerRepository>();
            services.AddScoped <IClassesTimeRepository, ClassesTimeRepository> ();
            services.AddScoped<IAudienceRepository, AudienceRepository>();
            services.AddScoped<ISemesterRepository, SemesterRepository>();
            services.AddScoped<IGroupRepository, GroupRepository>();
            services.AddScoped<ISubjectRepository, SubjectRepository>();
            services.AddScoped<IAcademicPlanRepository, AcademicPlanRepository>();
            services.AddScoped <ITimeTableRepository, TimeTableRepository> ();
            
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "TimetableOfClassesAPI", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "TimetableOfClassesAPI v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors("CorsPolicy");

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
