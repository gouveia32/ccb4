using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Pedido : DbObject, IEquatable<Pedido>
    {
        /// <summary>
        /// Cria um novo pedido.
        /// </summary>
        public Pedido()
        { }

        /// <summary>
        /// Cria um novo Pedido para um determinado Cliente.
        /// </summary>
        public Pedido(Cliente cliente) : this()
        {
            Cliente = cliente;
        }

        public int cliente_id { get; set; }
        public int empregado_id { get; set; }
        public DateTime? data_abertura { get; set; }
        public DateTime? data_fechamento { get; set; }
        public DateTime? data_pagamento { get; set; }
        public Double adicional { get; set; }
        public Double desconto { get; set; }
        public Double pago { get; set; }
        public Double valor { get; set; }
        public bool quitado { get; set; }
        public bool mensal { get; set; }
        public bool pago_antecipado { get; set; }
        public string obs_pedido { get; set; }
        public string obs_pagamento { get; set; }
        public bool executado { get; set; }

        public Cliente Cliente { get; set; }
        public virtual List<Item> Itens { get; set; } = new List<Item>();

        public bool Equals(Pedido other)
        {
            return
                this.cliente_id == other.cliente_id &&
                this.empregado_id == other.empregado_id &&
                this.data_abertura == other.data_abertura &&
                this.data_fechamento == other.data_fechamento &&
                this.data_pagamento == other.data_pagamento &&
                this.adicional == other.adicional &&
                this.desconto == other.desconto &&
                this.pago == other.pago &&
                this.valor == other.valor &&
                this.quitado == other.quitado &&
                this.mensal == other.mensal &&
                this.pago_antecipado == other.pago_antecipado &&
                this.obs_pedido == other.obs_pedido &&
                this.obs_pagamento == other.obs_pagamento &&
                this.executado == other.executado;
        }
    }
}
