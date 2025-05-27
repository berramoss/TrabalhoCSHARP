using Microsoft.EntityFrameworkCore;
using BarbeariaAPI.Models;

namespace BarbeariaAPI.Data;

public class BarbeariaContext : DbContext
{
    public BarbeariaContext(DbContextOptions<BarbeariaContext> options) : base(options) { }

    public DbSet<Agendamento> Agendamentos { get; set; }
}
