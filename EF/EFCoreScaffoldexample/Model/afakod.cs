using System;
using System.Collections.Generic;

#nullable disable

namespace EFCoreScaffoldexample.Model
{
    public partial class afakod
    {
        public int id { get; set; }
        public string nev { get; set; }
        public string leiras { get; set; }
        public decimal afa_sztt { get; set; }
        public string fksz_vissza { get; set; }
        public string fksz_fizetendo { get; set; }
        public DateTime? rogzites_idopontja { get; set; }
        public int? rogzito_szemely { get; set; }
        public DateTime? modositas_idopontja { get; set; }
        public int? modosito_szemely { get; set; }
    }
}
