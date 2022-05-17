using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtivEscola.Models
{
    internal class Escola
    {
        public int Id { get; set; }

        public string NomeFantasia { get; set; }

        public string Nome { get; set; }

        public string RazaoSocial { get; set; }

        public string Cnpj { get; set; }

        public string Inscricao { get; set; }

        public DateTime? Data_criacao { get; set; }

        public string Resp { get; set; }

        public string Resp_tel { get; set; }

        public string Email { get; set; }

        public string Numero { get; set; }

        public string Bairro { get; set; }

        public string Complemento { get; set; }

        public string Cep { get; set; }

        public string Cidade { get; set; }

        public string Estado { get; set; }

        public string Tipo { get; set; }

        private string _tipo;

        private string _Tipo => _Tipo;

        public void SetTipo(bool t = true)
        {
            _tipo = t == true ? "público" : "privado";
        }

        
    }
}
