using ApiProveedor.Models;

namespace ApiProveedor.Repositories
{
    public interface IProveedorRepository
    {
        Task<IEnumerable<Proveedor>> GetProveedors();
        Task<Proveedor> GetProveedorById(int id);
        Task<Proveedor> CreateProveedor(Proveedor proveedor);
        Task<Proveedor> UpdateProveedor(Proveedor proveedor);
        Task<bool> DeleteProveedor(int id);
    }
}
