﻿using System;
using System.Collections.Generic;

namespace OnlineCatering.Models;

public partial class CatererLogin
{
    public int Id { get; set; }

    public string Restaurant { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string Address { get; set; } = null!;

    public DateTime? RegDate { get; set; }

    public virtual ICollection<Message> MessageFromCaterers { get; set; } = new List<Message>();

    public virtual ICollection<Message> MessageToCaterers { get; set; } = new List<Message>();

    public virtual ICollection<RawMaterial> RawMaterials { get; set; } = new List<RawMaterial>();

    public virtual ICollection<SupplierOrderChild> SupplierOrderChildren { get; set; } = new List<SupplierOrderChild>();

    public virtual ICollection<SupplierOrder> SupplierOrders { get; set; } = new List<SupplierOrder>();
}
