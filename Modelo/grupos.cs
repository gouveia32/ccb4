namespace ccb.Models
{
    using System;
    using System.Collections.Generic;

    public partial class grupos
    {
        public byte id { get; set; }

        public string nome { get; set; }

        public int? OptimisticLockField { get; set; }

        public int? GCRecord { get; set; }
    }
}
