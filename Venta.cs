using System;
using System.Collections.Generic;

namespace ExamenCRUD.Models;

public partial class Venta
{
    public int Factura { get; set; }

    public DateTime? Fecha { get; set; }

    public int Total { get; set; }
}
