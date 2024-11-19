﻿using System;
using System.Collections.Generic;
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
        public string Pais { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}