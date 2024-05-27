﻿using System;
using System.Collections.Generic;

namespace Teknoser_Log_Zipper.Models.Northwind;

public partial class AyrintiliSatisDetaylari
{
    public int SatisId { get; set; }

    public int UrunId { get; set; }

    public string UrunAdi { get; set; } = null!;

    public decimal BirimFiyati { get; set; }

    public short Miktar { get; set; }

    public float İndirim { get; set; }

    public decimal? ExtendedPrice { get; set; }
}
