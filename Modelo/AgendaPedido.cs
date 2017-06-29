using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class AgendaPedido : DbObject, IEquatable<AgendaPedido>
    {
        /// <summary>
        /// Cria um novo AgendaPedido.
        /// </summary>
        public AgendaPedido()
        { }

        public int pedido_id { get; set; } = 0;
        public string subject { get; set; }
        public string description { get; set; }
        public string location { get; set; }
        public int label { get; set; }
        public int status { get; set; }
        public DateTime? start { get; set; }
        public DateTime? end { get; set; }

        public bool Equals(AgendaPedido other)
        {
            return
                this.pedido_id == other.pedido_id &&
                this.subject == other.subject &&
                this.description == other.description &&
                this.location == other.location &&
                this.label == other.label &&
                this.status == other.status &&
                this.start == other.start &&
                this.end == other.end;
        }
    }
}
