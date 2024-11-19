using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Helpers;

namespace CrudEmpresa.ViewModel.Empresa
{
    public class EmpresaFormViewModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(14)]
        public string CNPJ { get; set; }

        [Required]
        [StringLength(100)]
        public string Nome { get; set; }

        [Required]
        [StringLength(11)]
        public string Telefone { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        [Required]
        [StringLength(40)]
        public string Pais { get; set; }

        [Required]
        [Display(Name = "Data cadastro")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataCadastro { get; set; }
    }
}