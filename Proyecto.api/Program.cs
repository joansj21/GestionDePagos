using Microsoft.EntityFrameworkCore;
using Proyecto.BW.CU;
using Proyecto.BW.Interfaces.BW;
using Proyecto.BW.Interfaces.SG;
using Proyecto.DA.Acciones;
using Proyecto.DA.Contexto;
using Proyecto.SG;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpClient();

builder.Services.AddTransient<IGestionarPagoBW, GestionarPagoBW>();
builder.Services.AddTransient<IGestionarPagoDA, GestionarPagoDa>();
builder.Services.AddTransient<IGestionarPagoSG, GestionarPagoSG>();

builder.Services.AddDbContext<GestionPagoContext>(options =>
{
    var connectionsString = "Data Source=163.178.107.10;User Id=Laboratorios;Password=TUy&)&nfC7QqQau.%278UQ24/=%;Initial Catalog=J_GestionPago;TrustServerCertificate=true;";
    options.UseSqlServer(connectionsString);
});


var app = builder.Build();

app.UseCors("AllowOrigin");
app.UseCors(options =>
{
    options.AllowAnyOrigin();
    options.AllowAnyMethod();
    options.AllowAnyHeader();
});

// Configure the HTTP request pipeline.

app.UseSwagger();
    app.UseSwaggerUI();


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
