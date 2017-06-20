using System;
using System.Collections.Generic;

namespace Modelo
{

    public partial class Bordado : DbObject, IEquatable<Bordado>
    {
        public string arquivo { get; set; } = "";

        public string descricao { get; set; } = "";

        public string caminho { get; set; } = "";

        public string disquete { get; set; } = "";

        public string bastidor { get; set; } = "";

        public int grupo_id { get; set; } = 0;

        public decimal preco { get; set; } = 0;

        public int cores { get; set; } = 0;

        public int pontos { get; set; } = 0;

        public int largura { get; set; } = 0;

        public int altura { get; set; } = 0;

        public int metragem { get; set; } = 0;

        public bool aprovado { get; set; } = false;

        public byte[] imagem { get; set; } = null;

        public string obs_publica { get; set; } = "";

        public string obs_restrita { get; set; } = "";

        public bool Equals(Bordado other)
        {
            return
                this.arquivo == other.arquivo &&
                this.descricao == other.descricao &&
                this.caminho == other.caminho &&
                this.disquete == other.disquete &&
                this.bastidor == other.bastidor &&
                this.cores == other.cores &&
                this.pontos == other.pontos &&
                this.largura == other.largura &&
                this.altura == other.altura &&
                this.preco == other.preco &&
                this.imagem == other.imagem &&
                this.obs_publica == other.obs_publica &&
                this.obs_restrita == other.obs_restrita;
        }

    }
}
