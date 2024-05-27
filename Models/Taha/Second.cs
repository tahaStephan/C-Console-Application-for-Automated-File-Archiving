using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Teknoser_Log_Zipper.Models.Taha;

public class Second
{
    [Key]
    public int ID { get; set; }
    public string Yazi { get; set; }
    public int Sayi { get; set; }
}

