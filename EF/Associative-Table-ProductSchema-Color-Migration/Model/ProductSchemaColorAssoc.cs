using System;
using System.Collections.Generic;

#nullable disable

namespace AssoTabM.Model
{
    public partial class ProductSchemaColorAssoc
    {
        public int ProductSchemaColorAssocId { get; set; }
        public int ProductSchemaId { get; set; }
        public int ColorId { get; set; }

        public virtual Color Color { get; set; }
        public virtual ProductSchema ProductSchema { get; set; }
    }
}
