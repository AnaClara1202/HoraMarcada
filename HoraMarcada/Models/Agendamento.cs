using System.ComponentModel.DataAnnotations;

namespace HoraMarcada.Models
{
    public class Agendamento
    {
        [Key] // Isso avisa ao banco que o Id é a chave primária
        public int Id { get; set; }
        public string NomeCliente { get; set; }
        public DateTime DataHora { get; set; }
    }
}
