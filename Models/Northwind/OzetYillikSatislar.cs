using System;
using System.Collections.Generic;

namespace Teknoser_Log_Zipper.Models.Northwind;

public partial class OzetYillikSatislar
{
    public DateTime? SevkTarihi { get; set; }

    public int SatisId { get; set; }

    public decimal? Subtotal { get; set; }
}
