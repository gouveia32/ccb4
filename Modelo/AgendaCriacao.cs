using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class AgendaCriacao : DbObject, IEquatable<AgendaCriacao>
    {
        /// <summary>
        /// Cria um novo AgendaPedido.
        /// </summary>
        public AgendaCriacao()
        { }

        public int pedido_id { get; set; }
        public string subject { get; set; }
        public string location { get; set; }
        public int label { get; set; }
        public int status { get; set; }
        public DateTime? start { get; set; }
        public DateTime? end { get; set; }

        public bool Equals(AgendaCriacao other)
        {
            return
                this.pedido_id == other.pedido_id &&
                this.subject == other.subject &&
                this.location == other.location &&
                this.label == other.label &&
                this.status == other.status &&
                this.start == other.start &&
                this.end == other.end;
        }
    }
}
