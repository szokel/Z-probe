using System;
using System.Collections.Generic;

#nullable disable

namespace AssoTabM.Model
{
    public partial class Color
    {
        public Color()
        {
            ProductSchemaColorAssocs = new HashSet<ProductSchemaColorAssoc>();
        }

        public int ColorId { get; set; }
        public string Name { get; set; }
        public string Comments { get; set; }

        public virtual ICollection<ProductSchemaColorAssoc> ProductSchemaColorAssocs { get; set; }
    }
}
