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
            Persistencia.PopularArquivo("amigos.csv", listaDeAmizades);
            AtualizarLista(listaDeAmizades);
        }

        //Cadastrar uma nova amizade
        private void ButtonCadastrar_Click(object sender, EventArgs e)
        {
            if (File.Exists("secreto.csv") && new FileInfo("secreto.csv").Length > 0)
            {
                MessageBox.Show("Os nomes já foram embaralhados e estão definidos. Caso você inclua outra pessoa, lembre-se de embaralhar novamente!", "Aviso");
            }
            FormCadastrar modalCadastrar = new FormCadastrar(listaDeAmizades, this);
            modalCadastrar.ShowDialog();
            AtualizarLista(listaDeAmizades);
        }

        //Mostra os nomes na listView
        public void AtualizarLista(List<Amizade> listaAmizades)
        {
            listViewNomes.Items.Clear();
            foreach (var amizade in listaAmizades)
            {
                ListViewItem novoItem = new ListViewItem();
                novoItem.Text = amizade.Nome; 
                novoItem.SubItems.Add(amizade.Email); 
                listViewNomes.Items.Add(novoItem);
            }
        }

        private void ButtonMatch_Click(object sender, EventArgs e)
        {
            if (listaDeAmizades.Count < 2)
            {
                MessageBox.Show("É preciso que hajam ao menos duas amizades cadastrados.", "Aviso");
                return;
            }

            if (File.Exists("secreto.csv") && new FileInfo("secreto.csv").Length > 0)
            {
                DialogResult result = MessageBox.Show("Já existe um relação de match de amizades, deseja gerar novamente?", "Aviso", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    return;
                }
            }

            // Dar Match nas Amizades
            List<Amizade> listaAux = new List<Amizade>(listaDeAmizades);
            Random random = new Random();

            for (int i = 0; i < 1000; i++) // Limitar a 1000 tentativas para evitar loops infinitos
            {
                listaAux = listaAux.OrderBy(x => random.Next()).ToList();

                bool paresIguais = false;
                for (int j = 0; j < listaDeAmizades.Count; j++)
                {
                    if (listaDeAmizades[j] == listaAux[j])
                    {
                        paresIguais = true;
                        break;
                    }
                }

                if (!paresIguais)
                {
                    Persistencia.GerarArquivoMatchAmizades(listaDeAmizades, listaAux);
                    MessageBox.Show("Você deu match entre as amizades!", "Aviso");
                    return;
                }
            }

            MessageBox.Show("Não foi possível gerar pares secretos únicos após várias tentativas. Tente novamente.", "Aviso");

        }

        private void ButtonApagar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja apagar tudo?", "Aviso", MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
            {
                return;
            }
            listaDeAmizades.Clear();
            listViewNomes.Items.Clear();
            Persistencia.LimparArquivo("amigos.csv");
            Persistencia.LimparArquivo("secreto.csv");
        }

        private void ButtonVerMatchs_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja ver quem tirou quem? Assim você vai acessar todos os matchs das amizades.", "Aviso", MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
            {
                return;
            }
            
           VerMatchs exibirMartchs = new VerMatchs();
            exibirMartchs.ShowDialog();
        }
    }
}
