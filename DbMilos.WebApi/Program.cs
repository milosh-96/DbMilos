
using DbMilos.Application;
using DbMilos.Domain.Interfaces;
using System.ComponentModel;
using System.Diagnostics;
using System.Text.Json.Serialization;

namespace DbMilos.WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers().AddJsonOptions(opt => { 
                opt.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
               
            });
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            // tools //
            builder.Services.AddScoped<IListParser, ListParser>();
            builder.Services.AddScoped<IListTransformer, ListTransformer>();
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("specificorigins", policy =>
                {
                    policy.WithHeaders("Content-Type");
                    policy.WithOrigins("https://dbmilos.com");
                    policy.WithOrigins("http://localhost:5173");
                });
            });
            var app = builder.Build();

            app.UseCors("specificorigins");

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

          


            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();
            app.UseCors();
            app.Run();
        }
    }
}
