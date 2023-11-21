using APIBookMyShowD.Database;
using APIBookMyShowD.Repository;
using APIBookMyShowD.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace APIBookMyShowD
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
            builder.Services.AddTransient<IMultiplexServices, MultiplexService>();
            builder.Services.AddTransient<IMovieService, MovieService>();
            builder.Services.AddTransient<ICityService, CityService>();
            builder.Services.AddTransient<IUserService,UserService>();
            builder.Services.AddTransient<MyContext>();

            //Configure Authentication Schema to validate Token



            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            
            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}