﻿using System;
using System.Collections.Generic;

namespace SistemaVenta.Model;

public partial class Producto
{
    public int IdProducto { get; set; }

    public string? NombreProducto { get; set; }

    public int? IdCategoria { get; set; }

    public int? Stock { get; set; }

    public decimal? Precio { get; set; }

    public bool? EsActivo { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public virtual ICollection<DetalleVentum> DetalleVenta { get; } = new List<DetalleVentum>();

    public virtual Categoria? IdCategoriaNavigation { get; set; }
}
