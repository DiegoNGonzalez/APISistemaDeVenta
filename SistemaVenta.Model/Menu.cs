using System;
using System.Collections.Generic;

namespace SistemaVenta.Model;

public partial class Menu
{
    public int IdMenu { get; set; }

    public string? NombreMenu { get; set; }

    public string? IconoMenu { get; set; }

    public string? Url { get; set; }

    public virtual ICollection<MenuRol> MenuRols { get; } = new List<MenuRol>();
}
