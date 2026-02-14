using Microsoft.AspNetCore.Mvc;
using WebApplicationAPP.Bussines;
using WebApplicationAPP.Models;

namespace WebApplicationAPP.Controllers
{
    public class ClientesController : Controller
    {
        private readonly ClientesBussiness _clientesBussiness;

        public ClientesController(ClientesBussiness clientesBussiness)
        {
            _clientesBussiness = clientesBussiness;
        }


        public IActionResult Index()
        {
            return View(_clientesBussiness.GetAllPersonas());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Clientes clientes)
        {
            if (!ModelState.IsValid)
            {
                return View(clientes);
            }
            _clientesBussiness.AddPersona(clientes);

            return RedirectToAction(nameof(Index));
        }



        public IActionResult Edit(int id)
        {
            return View(_clientesBussiness.GetPersonaById(id));
        }


        public IActionResult Details(int id)
        {
            return View(_clientesBussiness.GetPersonaById(id));
        }


        [HttpPost]
        public IActionResult Edit(Clientes clientes)
        {
            _clientesBussiness.UpdatePersona(clientes);
            return RedirectToAction("Index");
        }


        public IActionResult Delete(int id)
        {
            return View(_clientesBussiness.GetPersonaById(id));
        }


        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmar(int id)
        {
            _clientesBussiness.DeletePersona(id);
            return RedirectToAction(nameof(Index));
        }

    }
}