using APICrud.Data;

using APICrud.Estudantes;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddScoped<AppDbContext>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

//app.MapGet("HelloWorld", () => "Hello World!");
//EstudantesRotas.AddRotasEstudantes(app);

//Configurando as rotas!
app.AddRotasEstudantes();
app.Run();

