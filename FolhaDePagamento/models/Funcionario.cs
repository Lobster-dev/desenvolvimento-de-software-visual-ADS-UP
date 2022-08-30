using System;

namespace API.Models
{
    public class Funcionario
    {
        public Funcionario() => CreatedAt = DateTime.Now;
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string DataDeNascimento { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}