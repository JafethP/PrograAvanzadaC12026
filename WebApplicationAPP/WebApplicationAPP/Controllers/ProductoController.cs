using Microsoft.AspNetCore.Mvc;
using WebApplicationAPP.Bussines;
using WebApplicationAPP.Models;


namespace WebApplicationAPP.Controllers
{
    public class ProductoController : Controller
    {
        private readonly ProductoBussiness _productoBussiness;

        public ProductoController(ProductoBussiness productoBussiness)
        {
            _productoBussiness = productoBussiness;
        }


        public IActionResult Index()
        {
            return View(_productoBussiness.GetAllProducto());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Producto producto)
        {
            if (!ModelState.IsValid)
            {
                return View(producto);
            }
            _productoBussiness.AddProducto(producto);

            return RedirectToAction(nameof(Index));
        }



        public IActionResult Edit(int id)
        {
            return View(_productoBussiness.GetProductoById(id));
        }


        public IActionResult Details(int id)
        {
            return View(_productoBussiness.GetProductoById(id));
        }


        [HttpPost]
        public IActionResult Edit(Producto producto)
        {
            _productoBussiness.UpdateProducto(producto);
            return RedirectToAction("Index");
        }


        public IActionResult Delete(int id)
        {
            return View(_productoBussiness.GetProductoById(id));
        }


        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmar(int id)
        {
            _productoBussiness.DeleteProducto(id);
            return RedirectToAction(nameof(Index));
        }

    }
}