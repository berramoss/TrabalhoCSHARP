using Microsoft.EntityFrameworkCore;
using BarbeariaAPI.Data;
using BarbeariaAPI.Rotas;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<BarbeariaContext>(options =>
    options.UseMySql("server=localhost;database=barbearia;user=root;password=Mikar@paulo0109;",
        new MySqlServerVersion(new Version(8, 0, 32)))); // Ajuste a versão do seu MySQL

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<BarbeariaContext>();
    db.Database.EnsureCreated();

    if (!db.Agendamentos.Any())
    {
        db.Agendamentos.AddRange(new[]
        {
            new() { NomeCliente = "Carlos", Servico = "Corte", DataHora = DateTime.Now.AddHours(1), Telefone = "99999-1111" },
            new() { NomeCliente = "João", Servico = "Barba", DataHora = DateTime.Now.AddHours(2), Telefone = "99999-2222" },
            new() { NomeCliente = "Maria", Servico = "Corte e Barba", DataHora = DateTime.Now.AddHours(3), Telefone = "99999-3333" }
            
        });
        db.SaveChanges();
    }
}

app.MapGetEndpoints();
app.MapPostEndpoints();
app.MapDeleteEndpoints();

app.Run();

