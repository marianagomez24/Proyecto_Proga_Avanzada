using BackEnd.Services.Implementations;
using BackEnd.Services.Interfaces;
using DAL.Implementations;
using DAL.Interfaces;
using Entities.Entities;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#region DI
builder.Services.AddDbContext<KyomuDbContext>();
builder.Services.AddScoped<IUnidadDeTrabajo, UnidadDeTrabajo>();
builder.Services.AddScoped<IPagoService, PagoService>();
builder.Services.AddScoped<IPagoDAL, PagoDAL>();
builder.Services.AddScoped<IPedidoDAL, PedidoDAL>();
builder.Services.AddScoped<IPagoService, PagoService>();
builder.Services.AddScoped<IPedidoService, PedidoService>();
builder.Services.AddScoped<ICategoriaService, CategoriaService>();
builder.Services.AddScoped<IPlatilloService, PlatilloService>();
builder.Services.AddScoped<IReseñaService, ReseñaService>();
builder.Services.AddScoped<IRolService, RolService>();
builder.Services.AddScoped<IUsuarioService, UsuarioService>();
#endregion

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
