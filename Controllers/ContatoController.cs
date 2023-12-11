using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ASPNET.Context;
using ASPNET.Models;

namespace ASPNET.Controllers
{
    public class ContatoController : Controller
    {
        private readonly AgendaContext _context;

        public ContatoController(AgendaContext context)
        {
            _context = context;
        }
        public IActionResult Index() {
            var contatos = _context.Contatos.ToList();
            
            return View(contatos);
        }

        public IActionResult Criar() {
            return View();
        }


        // Após preenchidos, os forms irão desempenhar a função de Post.
        [HttpPost]
        public IActionResult Criar(Contato contato){
            if (ModelState.IsValid) {
                _context.Contatos.Add(contato);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));    
            }
            return View(contato);
        }

        // Busca o contato no banco de dados para ser editado
        public IActionResult Editar(int id) {
            // Busca o contato por ID
            var contato = _context.Contatos.Find(id);
            // Se não for encontrado, retorna not found.
            if (contato == null) {
                //return NotFound();
                // Ao invés de retornar not found, vamos tentar retornar para o indice.
                return RedirectToAction(nameof(Index));
            }
            // Se não, retorna o contato
            return View(contato);
        }

        public IActionResult Detalhes(int id) {
            var contato = _context.Contatos.Find(id);

            if (contato == null) {
                return RedirectToAction(nameof(Index));
            }
            return View(contato);
        }

         public IActionResult Deletar(int id) {
            var contato = _context.Contatos.Find(id);

            if (contato == null) {
                return RedirectToAction(nameof(Index));
            }
            return View(contato);
        }

        [HttpPost]
        public IActionResult Deletar(Contato contato) {
            var contatoBanco = _context.Contatos.Find(contato.Id);

            _context.Contatos.Remove(contatoBanco);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}