using System;
using System.Collections.Generic;

namespace Modelo
{
    public partial class Catalogo : DbObject, IEquatable<Catalogo>
    {
        public string nome { get; set; }
        public int bordado_id { get; set; }

        public bool Equals(Catalogo other)
        {
            return
                this.nome == other.nome &&
                this.bordado_id == other.bordado_id;
        }
    }
}
