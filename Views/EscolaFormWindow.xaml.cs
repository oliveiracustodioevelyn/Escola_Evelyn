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
using AtivEscola.Models;
using AtivEscola.DataBase;

namespace AtivEscola.Views
{
    /// <summary>
    /// Lógica interna para EscolaFormWindow.xaml
    /// </summary>
    public partial class EscolaFormWindow : Window
    {
        private Escola _escola = new Escola();
        public EscolaFormWindow()
        {
            InitializeComponent();
        }
        private void BtSalvar_Click(object sender, RoutedEventArgs e)
        {
            _escola.Data_criacao = TxtData.SelectedDate;
            _escola.NomeFantasia = TxtNomeFantasia.Text;
            _escola.RazaoSocial = TxtRazao.Text;
            _escola.Cnpj = TxtCNPJ.Text;
            _escola.Inscricao = TxtInsc.Text;
             
            _escola.Nome = TxtNome.Text;
            _escola.Resp_tel = TxtTelefoneResp.Text;
            _escola.Email = TxtEmail.Text;
            _escola.Numero = TxtN.Text;
            _escola.Bairro = TxtBairro.Text;
            _escola.Complemento = TxtCompremento.Text;
            _escola.Cep = TxtCep.Text;
            _escola.Cidade = TxtCidade.Text;
            _escola.Estado = TxtEstado.Text;


            _escola.SetTipo((bool)RadioTipoPub.IsChecked);

            try
            {
                var dao = new EscolaDAO();
                dao.Insert(_escola);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
