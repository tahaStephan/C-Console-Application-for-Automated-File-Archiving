using System;
using System.Collections.Generic;

namespace Teknoser_Log_Zipper.Models.Northwind;

public partial class SatislarinToplamMiktari
{
    public decimal? SaleAmount { get; set; }

    public int SatisId { get; set; }

    public string SirketAdi { get; set; } = null!;

    public DateTime? SevkTarihi { get; set; }
}
