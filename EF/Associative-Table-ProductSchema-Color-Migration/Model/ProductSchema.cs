using System;
using System.Collections.Generic;

#nullable disable

namespace AssoTabM.Model
{
    public partial class ProductSchema
    {
        public ProductSchema()
        {
            ProductSchemaColorAssocs = new HashSet<ProductSchemaColorAssoc>();
        }

        public int ProductSchemaId { get; set; }
        public string Name { get; set; }
        public string Revision { get; set; }
        public int? SapproductCode { get; set; }
        public DateTime? ApprovalDate { get; set; }
        public string DrawingNr { get; set; }
        public string SerialNr { get; set; }
        public string Comments { get; set; }

        public virtual ICollection<ProductSchemaColorAssoc> ProductSchemaColorAssocs { get; set; }
    }
}
