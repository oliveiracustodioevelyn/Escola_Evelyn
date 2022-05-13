using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MySql.Data.MySqlClient;

namespace AtivEscola.Views
{
    /// <summary>
    /// Lógica interna para EscolaFormWindow.xaml
    /// </summary>
    public partial class EscolaFormWindow : Window
    {
        public EscolaFormWindow()
        {
            InitializeComponent();
        }
        private void BtSalvar_Click(object sender, RoutedEventArgs e)
        {
            string data_criacao = TxtData.SelectedDate?.ToString("yyyy-mm-dd");
            string fantasia = TxtNomeFantasia.Text;
            string razao = TxtRazao.Text;
            string cnpj = TxtCNPJ.Text;
            string inscricao = TxtInsc.Text;
            string data = TxtData.Text;
            string resp = TxtNome.Text;
            string resp_tel = TxtTelefoneResp.Text;
            string email = TxtEmail.Text;
            string numero = TxtN.Text;
            string bairro = TxtBairro.Text;
            string comp = TxtCompremento.Text;
            string cep = TxtCep.Text;
            string cidade = TxtCidade.Text;
            string estado = TxtEstado.Text;
            string tipo = "Privada";

            if ((bool)RadioTipoPub.IsChecked)
            {
                tipo = "Pública";
            }


            var conexao = new MySqlConnection("server=localhost; database=BD_ESCOLA; port=3360; user=root; password=root");

            conexao.Open();

            try
            {
                conexao.Close();
                var comando = conexao.CreateCommand();
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

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
