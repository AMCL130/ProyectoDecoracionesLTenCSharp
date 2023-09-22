using System;
using System.Collections.Generic;

namespace DecoracionesLTv4.Models;

public partial class Producto
{
    public int IdProducto { get; set; }

    public string Nombre { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public float Precio { get; set; }

    public string Estado { get; set; } = null!;

    public DateTime? FechaRegistro { get; set; }
}
