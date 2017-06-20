using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class Log : DbObject, IEquatable<Log>
    {
        public DateTime? data { get; set; }
        public string grupo { get; set; }
        public string sub_grupo { get; set; }
        public string descricao { get; set; }
        public string objeto { get; set; }

        public bool Equals(Log other)
        {
            return
                this.data == other.data &&
                this.grupo == other.grupo &&
                this.sub_grupo == other.sub_grupo &&
                this.descricao == other.descricao &&
                this.objeto == other.objeto;
        }
    }
}
