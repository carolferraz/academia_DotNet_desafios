using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmigoSecretoWinForms
{
    public partial class Form1 : Form
    {
        List<Amizade> listaDeAmizades = new List<Amizade>();
        public Form1()
        {
            InitializeComponent();
            Persistencia.popularArquivo("amigos.csv", listaDeAmizades);
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            if (File.Exists("secreto.csv") && new FileInfo("secreto.csv").Length > 0)
            {
                MessageBox.Show("Os nomes já foram embaralhados e estão definidos. Caso você inclua outra pessoa, lembre-se de embaralhar novamente!", "Aviso");
            }
            FormCadastrar fc = new FormCadastrar(listaDeAmizades, this);
            fc.ShowDialog();
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
