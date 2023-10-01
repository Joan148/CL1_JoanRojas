using ApiProveedor.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiProveedor.Repositories
{
    public class ProveedorRepository:IProveedorRepository

    {
        private readonly ProveedorSQLContext dbContext;
        public ProveedorRepository(ProveedorSQLContext dbContextgi)
        {
            this.dbContext = dbContext;
        }
        public async Task<Proveedor> CreateProveedor(Proveedor proveedor)
        {
            dbContext.Proveedors.Add(proveedor);
            await dbContext.SaveChangesAsync();
            return proveedor;
        }

        public async Task<IEnumerable<Proveedor>> GetProveedors()
        {
            return await dbContext.Proveedors.ToListAsync();
        }

        public async Task<Proveedor> GetProveedorById(int id)
        {
            var proveedor = await dbContext.Proveedors.Where(p => p.ProveedorId == id).FirstOrDefaultAsync();
            return proveedor;
        }

        public async Task<bool> DeleteProveedor(int id)
        {
            var proveedor = await dbContext.Proveedors.FirstOrDefaultAsync(p => p.ProveedorId == id);
            if (proveedor == null)
            {
                return false;
            }
            dbContext.Proveedors.Remove(proveedor);
            await dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<Proveedor> UpdateProveedor(Proveedor proveedor)
        {
            dbContext.Proveedors.Update(proveedor);

            await dbContext.SaveChangesAsync();

            return proveedor;
        }

    }
}
