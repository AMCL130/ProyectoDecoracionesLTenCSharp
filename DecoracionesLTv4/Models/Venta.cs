using System;
using System.Collections.Generic;

namespace DecoracionesLTv4.Models;

public partial class Venta
{
    public int IdVenta { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public string? Nombre { get; set; }

    public float Precio { get; set; }

    public DateTime? FechaRegistro { get; set; }
}
