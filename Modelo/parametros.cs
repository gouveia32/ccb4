using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Parametros : DbObject, IEquatable<Parametros>
    {
        public bool caixa_aberto { get; set; } = false;
        public DateTime? data_caixa_atual { get; set; }
        public DateTime? data_saldo_caixa_fechado { get; set; }
        public Decimal saldo_caixa { get; set; }
        public int SessaoTimeOut { get; set; }
        public int TempoAtualizaPedidos { get; set; }
        public bool NotificarEmail { get; set; }
        public string EmailNotificacao { get; set; }
        public string EmailOrigem { get; set; }
        public string Senha { get; set; }
        public string NomeEmpresa { get; set; }
        public string endereco { get; set; }
        public string telefone { get; set; }
        public int corPedidoNormal { get; set; }
        public int corPedidoMensal { get; set; }
        public int corCriacaoNormal { get; set; }
        public int corCriacaoUrgente { get; set; }
        public int corTarefaSelecionada { get; set; }

        public bool Equals(Parametros other)
        {
            return
                this.caixa_aberto == other.caixa_aberto &&
                this.data_caixa_atual == other.data_caixa_atual &&
                this.data_saldo_caixa_fechado == other.data_saldo_caixa_fechado &&
                this.saldo_caixa == other.saldo_caixa &&
                this.SessaoTimeOut == other.SessaoTimeOut &&
                this.TempoAtualizaPedidos == other.TempoAtualizaPedidos &&
                this.NotificarEmail == other.NotificarEmail &&
                this.EmailNotificacao == other.EmailNotificacao &&
                this.EmailOrigem == other.EmailOrigem &&
                this.Senha == other.Senha &&
                this.NomeEmpresa == other.NomeEmpresa &&
                this.endereco == other.endereco &&
                this.telefone == other.telefone &&
                this.corPedidoNormal == other.corPedidoNormal &&
                this.corPedidoMensal == other.corPedidoMensal &&
                this.corCriacaoNormal == other.corCriacaoNormal &&
                this.corCriacaoUrgente == other.corCriacaoUrgente &&
                this.corTarefaSelecionada == other.corTarefaSelecionada;
        }
    }
}
