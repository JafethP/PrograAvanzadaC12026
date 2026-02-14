using WebApplicationAPP.Data;
using WebApplicationAPP.Models;

namespace WebApplicationAPP.Repositories
{
    public class ProductoRepository : IProductoRepository
    {
        ///Declarar nuestras funciones por ejemplo
        /////CRUD
        ///
        private readonly AppDbContext _context;
        public ProductoRepository(AppDbContext context)
        {
            _context = context;
        }

        public List<Producto> GetAllProducto() { 
            return _context.Inventario_JafethPoveda.ToList();
        }
        public Producto GetProductoById(int id) { 
            return _context.Inventario_JafethPoveda.Find(id);
        }

        public void AddProducto(Producto producto) { 
            _context.Inventario_JafethPoveda.Add(producto);
            _context.SaveChanges();
        }

        public void UpdateProducto(Producto producto)
        {
            _context.Inventario_JafethPoveda.Update(producto);
            _context.SaveChanges();       
        }

        public void DeleteProducto(int id) { 
            var producto = GetProductoById(id);
            if (producto != null)
            {
                _context.Inventario_JafethPoveda.Remove(producto);
                _context.SaveChanges();
            }
        }
    }
}
