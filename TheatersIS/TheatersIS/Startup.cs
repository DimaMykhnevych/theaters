using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TheatersIs.BusinessLayer.Mappers;
using TheatersIs.BusinessLayer.Services.AddressService;
using TheatersIs.BusinessLayer.Services.PerformanceService;
using TheatersIs.BusinessLayer.Services.TheaterService;
using TheatersIS.DataLayer.Builders.PerformanceN;
using TheatersIS.DataLayer.Builders.TheaterN;
using TheatersIS.DataLayer.DbContextN;
using TheatersIS.DataLayer.Repositories.AddressRepositoryN;
using TheatersIS.DataLayer.Repositories.OrderRepositoryN;
using TheatersIS.DataLayer.Repositories.PerformanceRepositoryN;
using TheatersIS.DataLayer.Repositories.QuestionRepositoryN;
using TheatersIS.DataLayer.Repositories.TheaterPerformanceRepositoryN;
using TheatersIS.DataLayer.Repositories.TheaterRepositoryN;
using TheatersIS.DataLayer.Repositories.UserAnswerRepositoryN;
using TheatersIS.DataLayer.Repositories.UserRepositoryN;
using TheatersIS.DataLayer.Repositories.VariantRepositoryN;
using TheatersIS.Options;

namespace TheatersIS
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
            services.AddControllers();
            services.AddCors();

            services.AddDbContext<TheaterDbContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("TheatersDatabase")));

            services.AddSwaggerGen(x =>
            {
                x.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo());
            });

            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });

            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);

            services.AddTransient<IAddressRepository, AddressRepository>();
            services.AddTransient<IOrderRepository, OrderRepository>();
            services.AddTransient<IPerformanceRepository, PerformanceRepository>();
            services.AddTransient<IQuestionRepository, QuestionRepository>();
            services.AddTransient<ITheaterPerformanceRepository, TheaterPerformanceRepository>();
            services.AddTransient<ITheaterRepository, TheaterRepository>();
            services.AddTransient<IUserAnswerRepository, UserAnswerRepository>();
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IVariantRepository, VariantRepository>();

            services.AddTransient<ITheaterService, TheaterService>();
            services.AddTransient<IAddressService, AddressService>();
            services.AddTransient<IPerformanceService, PerformanceService>();

            services.AddTransient<ITheaterSearchQueryBuilder, TheaterSearchQueryBuilder>();
            services.AddTransient<IPerformanceSearchQueryBuilder, PerformanceSearchQueryBuilder>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            var swaggerOptions = new SwaggerOptions();
            Configuration.GetSection(nameof(SwaggerOptions)).Bind(swaggerOptions);

            app.UseSwagger(option => option.RouteTemplate = swaggerOptions.JsonRoute);
            app.UseSwaggerUI(option =>
            {
                option.SwaggerEndpoint(swaggerOptions.UiEndpoint, swaggerOptions.Description);
            });

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors(builder => builder.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
