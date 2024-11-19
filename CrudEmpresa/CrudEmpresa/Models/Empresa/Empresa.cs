using System;

namespace CrudEmpresa.Models
{
    public class Empresa
    {
        public int Id { get; set; }
        public string CNPJ { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Pais { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}