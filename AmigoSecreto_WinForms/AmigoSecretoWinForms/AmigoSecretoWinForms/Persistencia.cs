using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace AmigoSecretoWinForms
{
    public class Persistencia
    {
        public static void popularArquivo(string nomeArquivo, List<Amizade> lista)
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
                                Amizade tmp = new Amizade(vetorLinha[0], vetorLinha[1]);

                                if (!lista.Contains(tmp))
                                {
                                    lista.Add(tmp);
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
        private static void TratarExcecaoArquivo(Exception ex, string mensagem)
        {
            MessageBox.Show("Problemas com arquivo: " + mensagem + "\nDetalhes: " + ex.Message);
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

        public static void gerarArquivoAmigoSecreto(List<Amizade> lista, List<Amizade> listaTmp)
        {
            try
            {
                using (StreamWriter escritor = new StreamWriter("secreto.csv"))
                {
                    for (int i = 0; i < lista.Count; i++)
                    {
                        escritor.WriteLine(lista[i].Nome + ";" + lista[i].Email + ";" + listaTmp[i].Nome + ";" + listaTmp[i].Email);
                    }
                }
            }
            catch (IOException ex)
            {
                TratarExcecaoArquivo(ex, "Falha ao gerar arquivo");
            }
        }



    }
}

