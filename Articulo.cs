using System;
using System.Collections.Generic;

namespace ExamenCRUD.Models;

public partial class Articulo
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public int Precio { get; set; }

    public int Exist { get; set; }
}
