using System;
using System.Collections.Generic;

namespace DecoracionesLTv4.Models;

public partial class Cliente
{
    public int IdCliente { get; set; }

    public string Tipo { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public int Cedula { get; set; }

    public int? Telefono { get; set; }

    public string? Direccion { get; set; }

    public DateTime? FechaRegistro { get; set; }
}
