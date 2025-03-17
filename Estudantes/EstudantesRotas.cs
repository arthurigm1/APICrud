using APICrud.Data;

namespace APICrud.Estudantes;

public static class EstudantesRotas
{
    public static void AddRotasEstudantes(this WebApplication app)
    {
        var rotasEstudantes = app.MapGroup("estudantes");


        
        app.MapGet("estudantes", 
            () => new Estudante("Arthur"));

        app.MapPost("", async (AddEstudanteRequest req, AppDbContext context) =>
        {
            var estudante = new Estudante(req.Nome); 
            await context.Estudantes.AddAsync(estudante);
            await context.SaveChangesAsync();
        });
    }
}