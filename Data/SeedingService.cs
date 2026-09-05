using Trabalho1DevWebNet.Models;

namespace Trabalho1DevWebNet.Data;

public class SeedingService
{
    private readonly AppDbContext _context;

    public SeedingService(AppDbContext context)
    {
        _context = context;
    }

    public void Popula()
    {
        if (_context.Pacientes.Any())
        {
            return;
        }

        Paciente paciente1 = new Paciente
        {
            Nome = "João da Silva",
            Cpf = "123.456.789-00",
            Telefone = "(18) 99999-1111",
            Endereco = "Rua das Flores, 100",
            DataNascimento = new DateTime(1995, 5, 15)
        };

        Paciente paciente2 = new Paciente
        {
            Nome = "Maria Oliveira",
            Cpf = "987.654.321-00",
            Telefone = "(18) 98888-2222",
            Endereco = "Avenida Brasil, 250",
            DataNascimento = new DateTime(1988, 10, 20)
        };

        _context.Pacientes.AddRange(paciente1, paciente2);
        _context.SaveChanges();
    }
}
