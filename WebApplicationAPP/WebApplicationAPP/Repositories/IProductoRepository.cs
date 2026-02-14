using WebApplicationAPP.Models;

namespace WebApplicationAPP.Repositories
{
    public interface IProductoRepository
    {
        List<Producto> GetAllProducto();
        Producto GetProductoById(int id);
        void AddProducto(Producto producto);
        void UpdateProducto(Producto producto);
        void DeleteProducto(int id);

    }
}
