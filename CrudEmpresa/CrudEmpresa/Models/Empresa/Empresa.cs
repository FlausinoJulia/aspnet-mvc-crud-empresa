using System;
using System.ComponentModel;

namespace CrudEmpresa.Models
{
    public class Empresa
    {
        public int Id { get; set; }
        public string CNPJ { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        [DisplayName("País")]
        public string Pais { get; set; }
        [DisplayName("Data cadastro")]
        public DateTime DataCadastro { get; set; }
    }
}