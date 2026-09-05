using System.ComponentModel.DataAnnotations;

namespace Trabalho1DevWebNet.Models;

public class Paciente
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "O nome é obrigatório.")]
    [StringLength(100, MinimumLength = 3, ErrorMessage = "O nome deve ter entre 3 e 100 caracteres.")]
    public string Nome { get; set; } = string.Empty;

    [Required(ErrorMessage = "O CPF é obrigatório.")]
    [StringLength(14, MinimumLength = 11, ErrorMessage = "Informe um CPF válido.")]
    public string Cpf { get; set; } = string.Empty;

    [Required(ErrorMessage = "O telefone é obrigatório.")]
    [StringLength(20, MinimumLength = 8, ErrorMessage = "Informe um telefone válido.")]
    public string Telefone { get; set; } = string.Empty;

    [Required(ErrorMessage = "O endereço é obrigatório.")]
    [StringLength(200, MinimumLength = 5, ErrorMessage = "O endereço deve ter entre 5 e 200 caracteres.")]
    [Display(Name = "Endereço")]
    public string Endereco { get; set; } = string.Empty;

    [Required(ErrorMessage = "A data de nascimento é obrigatória.")]
    [DataType(DataType.Date)]
    [Display(Name = "Data de Nascimento")]
    public DateTime DataNascimento { get; set; }
}
