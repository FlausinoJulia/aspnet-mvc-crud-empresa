using CrudEmpresa.Database;
using CrudEmpresa.Models;
using CrudEmpresa.ViewModel.Empresa;
using System;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Helpers;
using System.Web.Mvc;
using System.Web.Services.Description;
using System.Web.UI;
using System.Xml.Serialization;

namespace CrudEmpresa.Controllers
{
    [Authorize]
    public class EmpresaController : Controller
    {
        private readonly EmpresaDbContext _context;

        public EmpresaController()
        {
            _context = new EmpresaDbContext();
        }

        public async Task<ActionResult> Index()
        {
            return View(
                await _context.Empresa
                    .Select(empresa => new EmpresaIndexViewModel
                    {
                        Id = empresa.Id,
                        CNPJ = empresa.CNPJ,
                        Nome = empresa.Nome,
                        Telefone = empresa.Telefone,
                        Email = empresa.Email,
                        Pais = empresa.Pais,
                        DataCadastro = empresa.DataCadastro
                    })
                    .ToListAsync()
            );
        }

        public async Task<ActionResult> Details(int id)
        {
            var empresa = await _context.Empresa.FirstOrDefaultAsync(e => e.Id == id);
            if (empresa == null) return HttpNotFound();

            var viewModel = new EmpresaDetailsViewModel
            {
                Id = empresa.Id,
                CNPJ = empresa.CNPJ,
                Nome = empresa.Nome,
                Telefone = empresa.Telefone,
                Email = empresa.Email,
                Pais = empresa.Pais,
                DataCadastro = empresa.DataCadastro
            };

            return View(viewModel);
        }

        public ActionResult Create()
        {
            return View(new EmpresaFormViewModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(EmpresaFormViewModel viewModel)
        {
            if (!ModelState.IsValid) return View(viewModel);

            var empresa = new Empresa
            {
                Id = viewModel.Id,
                CNPJ = viewModel.CNPJ,
                Nome = viewModel.Nome,
                Telefone = viewModel.Telefone,
                Email = viewModel.Email,
                Pais = viewModel.Pais,
                DataCadastro = viewModel.DataCadastro
            };

            _context.Empresa.Add(empresa);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        public async Task<ActionResult> Edit(int id)
        {
            var empresa = await _context.Empresa.FirstOrDefaultAsync(i => i.Id == id);
            if (empresa == null) return HttpNotFound();

            var viewModel = new EmpresaFormViewModel
            {
                Id = empresa.Id,
                CNPJ = empresa.CNPJ,
                Nome = empresa.Nome,
                Telefone = empresa.Telefone,
                Email = empresa.Email,
                Pais = empresa.Pais,
                DataCadastro = empresa.DataCadastro
            };

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(EmpresaFormViewModel viewModel)
        {
            if (!ModelState.IsValid) return View(viewModel);

            var empresa = await _context.Empresa.SingleOrDefaultAsync(e => e.Id == viewModel.Id);
            if (empresa == null) return HttpNotFound();

            empresa.Id = viewModel.Id;
            empresa.CNPJ = viewModel.CNPJ;
            empresa.Nome = viewModel.Nome;
            empresa.Telefone = viewModel.Telefone;
            empresa.Email = viewModel.Email;
            empresa.Pais = viewModel.Pais;
            empresa.DataCadastro = viewModel.DataCadastro;

            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        public async Task<ActionResult> Delete(int id)
        {
            var empresa = await _context.Empresa.FirstOrDefaultAsync(e => e.Id == id);
            if (empresa == null) return HttpNotFound();

            var viewModel = new EmpresaDeleteViewModel
            {
                Id = id,
                CNPJ = empresa.CNPJ,
                Nome = empresa.Nome,
            };

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            var empresa = await _context.Empresa.FirstOrDefaultAsync(e => e.Id == id);
            if (empresa == null) return HttpNotFound();

            _context.Empresa.Remove(empresa);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}