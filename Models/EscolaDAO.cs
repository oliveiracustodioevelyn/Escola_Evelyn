using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AtivEscola.DataBase;

namespace AtivEscola.Models
{
    internal class EscolaDAO
    {
        private static Conexao _conn = new Conexao();

        public void Insert(Escola escola)
        {
            /*
            try
            {
                var conexao = new Conexao();
                var comando = conexao.Query();

                comando.CommandText = "INSERT INTO Escola values(null,@nome, @razao, @cnpj,@inscricao, @tipo, @data_criacao, @resp, " +
                "@resp_tel, @email, @numero, @bairro, @complemento, @cep, @cidade, @estado);";

                comando.Parameters.AddWithValue("@nome", fantasia);
                comando.Parameters.AddWithValue("@razao", razao);
                comando.Parameters.AddWithValue("@cnpj", cnpj);
                comando.Parameters.AddWithValue("@inscricao", inscricao);
                comando.Parameters.AddWithValue("@tipo",tipo);
                comando.Parameters.AddWithValue("@data_criacao", data);
                comando.Parameters.AddWithValue("@resp", resp);
                comando.Parameters.AddWithValue("@resp_tel", resp_tel);
                comando.Parameters.AddWithValue("@email", email);
                comando.Parameters.AddWithValue("@numero", numero);
                comando.Parameters.AddWithValue("@bairro", bairro);
                comando.Parameters.AddWithValue("@complemento", comp);
                comando.Parameters.AddWithValue("@cep", cep);
                comando.Parameters.AddWithValue("@cidade", cidade);
                comando.Parameters.AddWithValue("@estado", estado);


                var resultado = comando.ExecuteNonQuery();
                if (resultado > 0)
                {
                    MessageBox.Show("Registro salvo com socesso!");
                }

            }*/
        }
    }
}
