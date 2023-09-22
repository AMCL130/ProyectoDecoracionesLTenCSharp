using System;
using System.Collections.Generic;

namespace DecoracionesLTv4.Models;

public partial class Ingrediente
{
    public int IdIngrediente { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public bool? Estado { get; set; }

    public double Precio { get; set; }

    public DateTime? FechaRegistro { get; set; }
}
