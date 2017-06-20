using System;
using System.Collections.Generic;

namespace Modelo
{
    public partial class NotaEspecifica : IEquatable<NotaEspecifica>
    {
        public int bordado_id { get; set; } = 0;

        public int cliente_id { get; set; } = 0;

        public decimal valor { get; set; } = 0;

        public string obs { get; set; } = "";

        public bool Equals(NotaEspecifica other)
        {
            return
                this.bordado_id == other.bordado_id &&
                this.cliente_id == other.cliente_id &&
                this.valor == other.valor &&
                this.obs == other.obs;
        }
    }
}
