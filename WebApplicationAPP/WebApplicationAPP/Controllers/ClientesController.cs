using Microsoft.AspNetCore.Mvc;
using WebApplicationAPP.Models;

namespace WebApplicationAPP.Controllers
{
    public class ClientesController : Controller
    {
        // declaraciones de variables
        private static List<Clientes> clientes = new();

        private static int contadorIds = 1;

        private static bool isInitialized = false;

        public ClientesController()
        {
            if (!isInitialized)
            {
                clientes.AddRange(new List<Clientes>
                {
                    new Clientes
                    {
                        Id = contadorIds++,
                        Nombre = "Juan",
                        CorreoElectronico = "juan@mail.com",
                        Telefono = "123456789",
                        Direccion = "Calle 1",
                        FechaRegistro = DateTime.Now,
                        Activo = true
                    },
                    new Clientes
                    {
                        Id = contadorIds++,
                        Nombre = "Ana",
                        CorreoElectronico = "ana@mail.com",
                        Telefono = "987654321",
                        Direccion = "Calle 2",
                        FechaRegistro = DateTime.Now,
                        Activo = true
                    }
                });

                isInitialized = true;
            }
        }

        public IActionResult Index()
        {
            return View(clientes);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Clientes cliente)
        {
            if (!ModelState.IsValid)
            {
                return View(cliente);
            }

            clientes.Add(new Clientes
            {
                Id = contadorIds++,
                Nombre = cliente.Nombre,
                CorreoElectronico = cliente.CorreoElectronico,
                Telefono = cliente.Telefono,
                Direccion = cliente.Direccion,
                FechaRegistro = cliente.FechaRegistro,
                Activo = cliente.Activo
            });

            return RedirectToAction(nameof(Index));
        }

        // Details
        public IActionResult Details(int id)
        {
            var datosConsulta = clientes.FirstOrDefault(c => c.Id == id);

            if (datosConsulta == null)
            {
                return NotFound();
            }

            return View(datosConsulta);
        }

        public IActionResult Edit(int id)
        {
            var datosConsulta = clientes.FirstOrDefault(c => c.Id == id);

            if (datosConsulta == null)
            {
                return NotFound();
            }

            return View(datosConsulta);
        }

        [HttpPost]
        public IActionResult Edit(Clientes cliente)
        {
            var datosConsulta = clientes.FirstOrDefault(c => c.Id == cliente.Id);

            if (datosConsulta == null)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                return View(cliente);
            }

            datosConsulta.Nombre = cliente.Nombre;
            datosConsulta.CorreoElectronico = cliente.CorreoElectronico;
            datosConsulta.Telefono = cliente.Telefono;
            datosConsulta.Direccion = cliente.Direccion;
            datosConsulta.FechaRegistro = cliente.FechaRegistro;
            datosConsulta.Activo = cliente.Activo;

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id)
        {
            var datosConsulta = clientes.FirstOrDefault(c => c.Id == id);

            if (datosConsulta == null)
            {
                return NotFound();
            }

            return View(datosConsulta);
        }

        [HttpPost]
        public IActionResult Delete(Clientes cliente)
        {
            var datosConsulta = clientes.FirstOrDefault(c => c.Id == cliente.Id);

            if (datosConsulta == null)
            {
                return NotFound();
            }

            clientes.Remove(datosConsulta);

            return RedirectToAction(nameof(Index));
        }
    }
}