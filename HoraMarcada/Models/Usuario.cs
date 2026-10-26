using Microsoft.Extensions.Primitives;
using System.Net.Mail;

namespace HoraMarcada.Models
{
    public class Usuario
    {
        public string Email { get; set; }
        public string Senha { get; set; }
        public int DataCriacao { get; set; }
        public string Status { get; set; }

    }
}
