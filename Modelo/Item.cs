using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class Item : DbObject
    {
        /// <summary>
        /// Cria um novo pedido.
        /// </summary>
        public Item()
        { }

        /// <summary>
        /// Cria um novo Pedido para um determinado Cliente.
        /// </summary>
        public Item(Bordado bordado) : this()
        {
            Bordado = bordado;
        }
        public int pedido_id { get; set; }
        public Pedido Pedido { get; set; }
        public int item { get; set; }
        public int bordado_id { get; set; }

        public Bordado Bordado { get; set; }

        public string descricao { get; set; }
        public DateTime? data_entrega { get; set; }
        public DateTime? data_execucao { get; set; }
        public int pc_solicitadas { get; set; }
        public int pc_entregues { get; set; }
        public int pc_defeito { get; set; }
        public int pc_nao_bordadas { get; set; }
        public int pontos_extras { get; set; }
        public Double preco_por_peca { get; set; }

        public Double Subtotal => preco_por_peca * pc_entregues;

        public int material_id { get; set; }
        public int local_id { get; set; }
        public int lado { get; set; }
        public bool arte { get; set; }
        public bool aplicacao { get; set; }
        public bool bordado { get; set; }
        public bool cores { get; set; }
        public bool troca_rapida { get; set; }
        public string obs { get; set; }
    }
}
