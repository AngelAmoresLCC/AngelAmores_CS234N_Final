﻿using System;
using System.Collections.Generic;

namespace BitsClasses.Models
{
    public partial class HopType
    {
        public HopType()
        {
            Hops = new HashSet<Hop>();
        }

        public int HopTypeId { get; set; }
        public string? Name { get; set; }

        public virtual ICollection<Hop> Hops { get; set; }
    }
}
