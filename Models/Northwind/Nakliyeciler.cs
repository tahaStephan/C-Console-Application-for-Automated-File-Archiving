using System;
using System.Collections.Generic;

namespace Teknoser_Log_Zipper.Models.Northwind;

public partial class Nakliyeciler
{
    public int NakliyeciId { get; set; }

    public string SirketAdi { get; set; } = null!;

    public string? Telefon { get; set; }

    public virtual ICollection<Satislar> Satislars { get; set; } = new List<Satislar>();
}
