﻿using System;
using System.Collections.Generic;

namespace CloudComputing.Models;

public partial class DetailHoaDon
{
    public string IdHoaDon { get; set; } = null!;

    public string IdSp { get; set; } = null!;

    public string? TenSp { get; set; }

    public byte SoLuong { get; set; }

    public int DonGia { get; set; }

    public bool? State { get; set; }
}
