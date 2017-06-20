using System;
using System.Collections.Generic;

namespace Modelo
{
    public partial class Local : DbObject, IEquatable<Local>
    {
        public string local { get; set; }

        public bool Equals(Local other)
        {
            return
                this.local == other.local;
        }
    }
}
