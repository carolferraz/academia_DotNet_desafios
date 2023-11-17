using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmigoSecretoWinForms
{
    public partial class FormCadastrar : Form
    {
        private List<Amizade> lista;
        private Form1 form1;

        public FormCadastrar(List<Amizade> lista, Form1 form1)
        {
            InitializeComponent();
            this.lista = lista;
            this.form1 = form1;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            string nome = textBoxNome.Text;
            string email = textBoxEmail.Text;
            if (string.IsNullOrEmpty(nome) && string.IsNullOrEmpty(email))
            {
                labelNomeError.Text = "O campo Nome não pode ser vazio!";
                labelEmailError.Text = "O campo Email não pode ser vazio!";
                return;
            }
            if (string.IsNullOrEmpty(nome))
            {
                labelNomeError.Text = "O campo Nome não pode ser vazio!";
                textBoxNome.Focus();
                return;
            }
            else
            {
                labelNomeError.Text = ""; 
            }
            if (string.IsNullOrEmpty(email))
            {
                labelEmailError.Text = "O campo Email não pode ser vazio!";
                textBoxEmail.Focus();
                return;
            }
            else if (!Util.EmailValido(email))
            {
                labelEmailError.Text = "Email inválido!";
                textBoxEmail.Focus();
                return;
            }
            CadastrarAmizade();
            textBoxNome.Text = "";
            textBoxEmail.Text = "";
            labelNomeError.Text = "";
            labelEmailError.Text = "";
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void CadastrarAmizade()
        {
            string nome = textBoxNome.Text.Trim();
            string email = textBoxEmail.Text.Trim();

            Amizade amizade = new Amizade(nome, email);

            if (lista.Contains(amizade))
            {
                MessageBox.Show("O e-mail digitado já está em uso!", "Aviso");
            }
            else
            {
                try
                {
                    lista.Add(amizade);
                    lista.Sort((a, b) => a.Nome.CompareTo(b.Nome));
                    Persistencia.GravarAmizade(amizade, "amigos.csv");

                    textBoxEmail.Text = "";
                    textBoxNome.Text = "";

                    MessageBox.Show("Amizade cadastrada com sucesso!", "Sucesso");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao gravar os dados: " + ex.Message, "Erro");
                }
            }
        }
    }
}
