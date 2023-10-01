using ApiProveedor.Models;
using ApiProveedor.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ApiProveedor.Controllers
{
    [ApiController]
    [Route("api/v1/[provController]")]
    public class ProveedorController : ControllerBase
    {
            private readonly IProveedorRepository proveedorRepository;

            public ProveedorController(IProveedorRepository proveedorRepository)
            {
                this.proveedorRepository = proveedorRepository;
            }

            [HttpGet]
            [Route("/GetProveedores")]
            public async Task<IEnumerable<Proveedor>> GetProveedors()
            {
                return await proveedorRepository.GetProveedors();
            }

            [HttpGet]
            [Route("/GetProveedorById/{id}")]
            public async Task<Proveedor> GetProveedorById(int id)
            {
                return await proveedorRepository.GetProveedorById(id);
            }

            [HttpPost]
            [Route("/CreateProveedor")]
            public async Task<Proveedor> CreateProveedor(Proveedor proveedor)
            {
                return await proveedorRepository.CreateProveedor(proveedor);
            }

            [HttpPut]
            [Route("/UpdateProovedor")]
            public async Task<Proveedor> UpdateProveedor(Proveedor proveedor)
            {
                return await proveedorRepository.UpdateProveedor(proveedor);
            }

            [HttpPut]
            [Route("/DeleteCustomer")]
            public async Task<bool> DeleteProveedor(int id)
            {
                return await proveedorRepository.DeleteProveedor(id);
            }


        
    }
}
