namespace HoraMarcada.Models
{
    public class Agendamento
    {
        public int Id { get; set; }
        public DateTime DataHora { get; set; }
        public string NomeCliente { get; set; }
        public string Servico { get; set; }
        public string StatusAgendamento { get; set; }
    }
}