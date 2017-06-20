using System;
using System.Collections.Generic;

namespace Modelo
{
     public class Cliente : DbObject, IEquatable<Cliente>
    {

        public string nome { get; set; } = "";
        public string contato_funcao { get; set; } = "";
        public string contato_nome { get; set; } = "";
        public string cgc_cpf { get; set; } = "";
        public string inscr_estadual { get; set; } = "";
        public string endereco { get; set; } = "";
        public string cidade { get; set; } = "";
        public string estado { get; set; } = "";
        public string cep { get; set; } = "";
        public string telefone1 { get; set; } = "";
        public string telefone2 { get; set; } = "";
        public string telefone3 { get; set; } = "";
        public string email { get; set; } = "";
        public string obs { get; set; } = "";

        public bool Equals(Cliente other)
        {
            return
                this.nome == other.nome &&
                this.contato_funcao == other.contato_funcao &&
                this.contato_nome == other.contato_nome &&
                this.inscr_estadual == other.inscr_estadual &&
                this.cgc_cpf == other.cgc_cpf &&
                this.email == other.email &&
                this.telefone1 == other.telefone1 &&
                this.telefone2 == other.telefone2 &&
                this.telefone3 == other.telefone3 &&
                this.endereco == other.endereco &&
                this.cidade == other.cidade &&
                this.estado == other.estado &&
                this.cep == other.cep &&
                this.obs == other.obs;
        }
    }
}
