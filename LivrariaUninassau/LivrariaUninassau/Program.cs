using LivrariaUninassau.Data;
using LivrariaUninassau.Repositorios.Interfaces;
using LivrariaUninassau.Repositorios;
using Microsoft.EntityFrameworkCore;


namespace LivrariaUninassau
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

            builder.Services.AddEntityFrameworkSqlServer()
                .AddDbContext<LivrariaDBContext>(
                options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))

                );

            builder.Services.AddScoped<IEmprestimoRepositorio, EmprestimoRepositorio>();

            //services cors
            builder.Services.AddCors(p => p.AddPolicy("corsapp", builder =>
            {
                builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
            }));


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();


            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.UseRouting();
            app.UseCors("corsapp");


            app.MapControllers();

            app.Run();
        }
    }
}