using Microsoft.EntityFrameworkCore;
using BarbeariaAPI.Data;
using BarbeariaAPI.Models;

namespace BarbeariaAPI.Rotas;

public static class GetAgendamentos
{
    public static void MapGetEndpoints(this WebApplication app)
    {
        app.MapGet("/BarbeariaAPI/agendamentos", async (BarbeariaContext db) =>
        {
            return await db.Agendamentos.ToListAsync();
        });

        app.MapGet("/api/agendamentos/{id}", async (int id, BarbeariaContext db) =>
        {
            var agendamento = await db.Agendamentos.FindAsync(id);
            return agendamento is not null ? Results.Ok(agendamento) : Results.NotFound();
        });
    }
}
