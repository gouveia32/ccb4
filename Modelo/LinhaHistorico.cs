using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class LinhaHistorico : IEquatable<LinhaHistorico>
    {
        public string linha_id { get; set; }
        public DateTime? data { get; set; }
        public string acao { get; set; }
        public int est1_anterior { get; set; }
        public int est1_atual { get; set; }
        public int est2_anterior { get; set; }
        public int est2_atual { get; set; }

        public bool Equals(LinhaHistorico other)
        {
            return
                this.linha_id == other.linha_id &&
                this.data == other.data &&
                this.acao == other.acao &&
                this.est1_anterior == other.est1_anterior &&
                this.est1_atual == other.est1_atual &&
                this.est2_anterior == other.est2_anterior &&
                this.est2_atual == other.est2_atual;
        }
    }
}
