using System;
using System.Collections.Generic;

namespace Teknoser_Log_Zipper.Models.Northwind;

public partial class KategorilereGoreUrunler
{
    public string KategoriAdi { get; set; } = null!;

    public string UrunAdi { get; set; } = null!;

    public string? BirimdekiMiktar { get; set; }

    public short? HedefStokDuzeyi { get; set; }

    public bool Sonlandi { get; set; }
}
