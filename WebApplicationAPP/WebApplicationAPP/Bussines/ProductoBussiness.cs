using WebApplicationAPP.Models;
using WebApplicationAPP.Repositories;

namespace WebApplicationAPP.Bussines
{
    public class ProductoBussiness
    {
        private readonly IProductoRepository _productoRepository;

        public ProductoBussiness(IProductoRepository productoRepository)
        {
            _productoRepository = productoRepository;
        }

        public List<Producto> GetAllProducto()
        {
            return _productoRepository.GetAllProducto();
        }

        public Producto GetProductoById(int id)
        {
            return _productoRepository.GetProductoById(id);
        }
        public void AddProducto(Producto producto)
        {
            _productoRepository.AddProducto(producto);
        }

        public void UpdateProducto(Producto producto)
        {
            _productoRepository.UpdateProducto(producto);
        }

        public void DeleteProducto(int id) {
            _productoRepository.DeleteProducto(id);
        }   


    }
}
