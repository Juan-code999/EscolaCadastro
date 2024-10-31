using Biblioteca._01_Service;
using Biblioteca._01_Service.Interfaces;
using Biblioteca._02_Repositorios;
using Biblioteca._02_Repositorios.Data;
using Biblioteca._02_Repositorios.Interfaces;
using Escola._02_Repositorios.Data;
using TrabalhoFinal._01_Services;
using TrabalhoFinal._02_Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
InicializadorBd.Inicializar();
builder.Services.AddAutoMapper(typeof(MappingProfile));

builder.Services.AddScoped<IAlunoRepository, AlunoRepository>();
builder.Services.AddScoped<IAtividadeRepository, AtividadeRepository>();
builder.Services.AddScoped<ILivroRepository, LivroRepository>();
builder.Services.AddScoped<INotaRepository, NotaRepository>();
builder.Services.AddScoped<IProfessoresRepository, ProfessorRepository>();
builder.Services.AddScoped<ITurmaRepository, TurmaRepository>();

builder.Services.AddScoped<IAlunoService, AlunoService>();
builder.Services.AddScoped<IAtividadeService, AtividadeService>();
builder.Services.AddScoped<ILivroService, LivroService>();
builder.Services.AddScoped<INotaService, NotaService>();
builder.Services.AddScoped<IProfessorService, ProfessorService>();
builder.Services.AddScoped<ITurmaService, TurmaService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
