using BarbeariaAPI.Data;

namespace BarbeariaAPI.Rotas;

public static class DeleteAgendamento
{
    public static void MapDeleteEndpoints(this WebApplication app)
    {
    
        app.MapDelete("/api/agendamentos/{id}", async (int id, BarbeariaContext db) =>
        {
            var agendamento = await db.Agendamentos.FindAsync(id);
            if (agendamento is null) return Results.NotFound();

            db.Agendamentos.Remove(agendamento);
            await db.SaveChangesAsync();
            return Results.NoContent();
        });
    }
}
