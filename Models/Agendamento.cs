namespace BarbeariaAPI.Models;

public class Agendamento
{
    public int Id { get; set; }
    public string NomeCliente { get; set; } = string.Empty;
    public string Servico { get; set; } = string.Empty;
    public DateTime DataHora { get; set; }
    public string Telefone { get; set; } = string.Empty;
}