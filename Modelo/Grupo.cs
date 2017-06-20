using System;
using System.Collections.Generic;

namespace Modelo
{
    public partial class Grupo : DbObject, IEquatable<Grupo>
    {
        public string local { get; set; }

        public bool Equals(Grupo other)
        {
            return
                this.local == other.local;
        }
    }
}
