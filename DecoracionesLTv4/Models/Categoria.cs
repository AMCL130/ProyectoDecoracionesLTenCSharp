using System;
using System.Collections.Generic;

namespace DecoracionesLTv4.Models;

public partial class Categoria
{
    public int IdCategoria { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public bool? Estado { get; set; }

    public DateTime? FechaRegistro { get; set; }
}
