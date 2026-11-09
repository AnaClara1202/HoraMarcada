namespace HoraMarcada.Models;
public class Filiado
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Sobrenome { get; set; }
    public DateTime DataNascimento { get; set; }
    public string CPF { get; set; }
    public string Responsavel { get; set; }
}