using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace AmigoSecretoWinForms
{
    public class Persistencia
    {
        public static void PopularArquivo(string nomeArquivo, List<Amizade> lista)
        {
            try
            {
                using (StreamReader leitor = new StreamReader(nomeArquivo, Encoding.UTF8))
                {
                    while (!leitor.EndOfStream)
                    {
                        string linha = leitor.ReadLine();

                        if (!string.IsNullOrEmpty(linha))
                        {
                            string[] vetorLinha = linha.Split(';');

                            if (vetorLinha.Length >= 2)
                            {
                                Amizade aux = new Amizade(vetorLinha[0], vetorLinha[1]);

                                if (!lista.Contains(aux))
                                {
                                    lista.Add(aux);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Formato inválido na linha: " + linha);
                            }
                        }
                    }
                }
                lista.Sort((a, b) => a.Nome.CompareTo(b.Nome));
            }
            catch (IOException ex)
            {
                TratarExcecaoArquivo(ex, "Falha ao popular arquivo");
            }
        }
        public static void GravarAmizades(Amizade a, string nomeArquivo)
        {
            try
            {
                using (StreamWriter escritor = new StreamWriter(nomeArquivo, append: true))
                {
                    escritor.WriteLine(a.Nome + ";" + a.Email);
                }
            }
            catch (IOException ex)
            {
                TratarExcecaoArquivo(ex, "Falha ao gravar arquivo");
            }

        }

        public static void GerarArquivoMatchAmizades(List<Amizade> lista, List<Amizade> listaAux)
        {
            try
            {
                using (StreamWriter escritor = new StreamWriter("secreto.csv"))
                {
                    for (int i = 0; i < lista.Count; i++)
                    {
                        escritor.WriteLine(lista[i].Nome + ";" + lista[i].Email + ";" + listaAux[i].Nome + ";" + listaAux[i].Email);
                    }
                }
            }
            catch (IOException ex)
            {
                TratarExcecaoArquivo(ex, "Falha ao gerar arquivo");
            }
        }
        public static void LimparArquivo(string nomeArquivo)
        {
            try
            {
                File.WriteAllText(nomeArquivo, string.Empty);
            }
            catch (IOException ex)
            {
                TratarExcecaoArquivo(ex, "Falha ao limpar arquivo");
            }
        }

        public static void ExibirMatchs(string nomeArquivo, ListView listView)
        {
            try
            {
                string origem = "secreto.csv";

                listView.Items.Clear();

                if (File.Exists(origem))
                {
                    using (StreamReader leitor = new StreamReader(nomeArquivo, Encoding.UTF8))
                    {
                        while (!leitor.EndOfStream)
                        {
                            string linha = leitor.ReadLine();

                            if (!string.IsNullOrEmpty(linha))
                            {
                                string[] vetorLinha = linha.Split(';');

                                if (vetorLinha.Length >= 3)
                                {
                                    ListViewItem item = new ListViewItem(new[] { vetorLinha[0], vetorLinha[2] });
                                    listView.Items.Add(item);
                                }
                                else
                                {
                                    MessageBox.Show("Linha com formato inválido: " + linha);
                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("O arquivo 'secreto.csv' não foi encontrado.");
                }
            }
            catch (IOException ex)
            {
                TratarExcecaoArquivo(ex, "Falha ao ler arquivo");
            }
        }

        private static void TratarExcecaoArquivo(Exception ex, string mensagem)
        {
            MessageBox.Show("Problemas com arquivo: " + mensagem + "\nDetalhes: " + ex.Message);
        }

    }
}

