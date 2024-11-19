using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace CrudEmpresa.ViewModel.Empresa
{
    public class EmpresaDetailsViewModel
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