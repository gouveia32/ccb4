using System;
using System.Collections.Generic;

namespace Modelo
{
    public partial class Linha : IEquatable<Linha>
    {
        public string codigo { get; set; } = "";
        public string nome { get; set; } = "";
        public string material_nome { get; set; } = "";
        public string material_fabricante { get; set; } = "";
        public string material_tipo { get; set; } = "";
        public int cor { get; set; } = 0;
        public int estoque_1 { get; set; } = 0;
        public int estoque_2 { get; set; } = 0;
        public int minimo { get; set; } = 0;
        public int pedido { get; set; } = 0;
        public bool Equals(Linha other)
        {
            return
                this.codigo == other.codigo &&
                this.nome == other.nome &&
                this.material_nome == other.material_nome &&
                this.material_fabricante == other.material_fabricante &&
                this.material_tipo == other.material_tipo &&
                this.cor == other.cor &&
                this.estoque_1 == other.estoque_1 &&
                this.estoque_2 == other.estoque_2 &&
                this.minimo == other.minimo &&
                this.pedido == other.pedido;
        }
    }
}
