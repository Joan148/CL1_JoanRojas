using System;
using System.Collections.Generic;

namespace ApiProveedor.Models
{
    public partial class Proveedor
    {
        public int ProveedorId { get; set; }
        public string? Nombre { get; set; }
        public string? Direccion { get; set; }
        public string? Telefono { get; set; }
        public string? Email { get; set; }
    }
}
