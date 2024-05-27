using System;
using System.Collections.Generic;

namespace Teknoser_Log_Zipper.Models.Northwind;

public partial class KategorilereGoreSatislar
{
    public int KategoriId { get; set; }

    public string KategoriAdi { get; set; } = null!;

    public string UrunAdi { get; set; } = null!;

    public decimal? Urunlerales { get; set; }
}
