using pi3.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace pi3.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Contato()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contato(Contato user)
        {
            ContatoRepository ur = new ContatoRepository();
            ur.Inserir(user);
            ViewBag.Mensagem = "Contato realizado com sucesso!";
            return View();
        }

        public IActionResult Lista()
        {
            ContatoRepository ur = new  ContatoRepository();
            List<Contato> listagem = ur.Listar();
            return View(listagem);
        }

        public IActionResult Remover(int Id)
        {
            ContatoRepository ur = new ContatoRepository();
            Contato userLocalizado = ur.BuscarPorId(Id);
            ur.Excluir(userLocalizado);
            return RedirectToAction("Lista","Contato");
        }
        public IActionResult Editar(int Id)
        {
            ContatoRepository ur = new ContatoRepository();
            Contato userLocalizado = ur.BuscarPorId(Id);
            return View(userLocalizado);
        }
        [HttpPost]
        public IActionResult Editar(Contato user)
        {
            ContatoRepository ur = new ContatoRepository();
            ur.Alterar(user);
            return RedirectToAction("Lista","Contato");
        }
    }
    
    
}