using LocadoraDeVeiculos.DAL;
using LocadoraDeVeiculos.Model;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LocadoraDeVeiculos
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        private Pessoa pessoa;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void cb_genero_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        

        private void btn_salvar_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tb_cpf.Text))
            {
                Pessoa pessoa = new Pessoa
                {
                    Nome = tb_nome.Text,
                    CNH = tb_cnh.Text,
                    CPF = tb_cpf.Text,
                    DataNascimento = tb_dn.Text,
                    EMail = tb_email.Text,
                    Endereço = tb_endereco.Text,
                    Telefone1 = tb_tel1.Text,
                    Telefone2 = tb_tel2.Text,


                };
                if (PessoaDAO.Cadastrar(pessoa))
                {
                    MessageBox.Show("Cliente Salvo com Sucesso!");


                }

                else
                {
                    MessageBox.Show("Cliente Já cadastrado!");
                }
            }
        }
        private void btn_limpar_Click(object sender, RoutedEventArgs e)
        {
            tb_nome.Clear();
            tb_cnh.Clear();
            tb_cpf.Clear();
            tb_dn.Clear();
            tb_email.Clear();
            tb_endereco.Clear();
            tb_tel1.Clear();
            tb_tel2.Clear();
            tb_bairro.Clear();
            tb_cpf.Focus();
            cb_genero.SelectedIndex = -1;

        }

        private void btn_limparcarro_Click(object sender, RoutedEventArgs e)
        {
            tb_placa.Clear();
            tb_modelo.Clear();
            tb_renavan.Clear();
            tb_marca.Clear();
            tb_ano.Clear();
            //cb_classe.Clear();
            tb_cor.Clear();
            //cb_Combustível.Clear();
            tb_placa.Focus();
            cb_Combustível.SelectedIndex = -1;
            cb_classe.SelectedIndex = -1;

        }
    }
}

