using BarbeariaAPI.Data;
using BarbeariaAPI.Models;

namespace BarbeariaAPI.Rotas;

public static class PostAgendamento
{
    public static void MapPostEndpoints(this WebApplication app)
    {

        app.MapPost("/api/agendamentos", async (Agendamento agendamento, BarbeariaContext db) =>
        {
            db.Agendamentos.Add(agendamento);
            await db.SaveChangesAsync();
            return Results.Created($"/api/agendamentos/{agendamento.Id}", agendamento);
        });
    }
}
