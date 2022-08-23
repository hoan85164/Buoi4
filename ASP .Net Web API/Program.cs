using ASP_.Net_Web_API.Services;

namespace ASP_.Net_Web_API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddScoped<IEmployee, ServiceEmployee>();
            //builder.Services.AddTransient<IEmployee, ServiceEmployee>();
            //builder.Services.AddSingleton<IEmployee, ServiceEmployee>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();
            app.UseEndpoints(endpoints => 
            {
                endpoints.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{Id}");
                endpoints.MapControllers(); 
            });

            app.MapControllers();

            app.Run();
        }
    }
}