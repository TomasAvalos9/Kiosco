﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Service.Models;

public partial class Producto
{
    public int Id { get; set; }

    [Required]
    public string Nombre { get; set; } = null!;

    [Required]
    [DataType(DataType.Currency)]
    [DisplayFormat(DataFormatString = "{0:F2}", ApplyFormatInEditMode = true)]
    public decimal Precio { get; set; }
    public bool Eliminado { get; set; } = false;
    public bool Oferta { get; set; } = false;
    public string? Imagen { get; set; } = string.Empty;

    public override string ToString()
    {
        return Nombre;
    }

}
