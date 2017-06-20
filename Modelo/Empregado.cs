using System;
using System.Collections.Generic;

namespace Modelo
{
    public partial class Empregado : DbObject, IEquatable<Empregado>
    {
        public string nome { get; set; }
        public string funcao { get; set; }
        public DateTime? nascimento { get; set; }
        public DateTime? admissao { get; set; }
        public DateTime? demissao { get; set; }
        public string endereco { get; set; }
        public string cidade { get; set; }
        public string uf { get; set; }
        public string cep { get; set; }
        public string telefone1 { get; set; }
        public string telefone2 { get; set; }
        public string telefone3 { get; set; }
        public string email { get; set; }

        public bool Equals(Empregado other)
        {
            return
                this.nome == other.nome &&
                this.funcao == other.funcao &&
                this.nascimento == other.nascimento &&
                this.admissao == other.admissao &&
                this.demissao == other.demissao &&
                this.endereco == other.endereco &&
                this.cidade == other.cidade &&
                this.uf == other.uf &&
                this.cep == other.cep &&
                this.email == other.email &&
                this.telefone1 == other.telefone1 &&
                this.telefone2 == other.telefone2 &&
                this.telefone3 == other.telefone3 &&
                this.obs == other.obs;
        }
        public string obs { get; set; }

    }
}
