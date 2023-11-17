using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmigoSecretoWinForms
{
    public class Amizade
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public Amizade(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        public static bool JaCadastrado(string nome, List<Amizade> lista)
        {
            foreach (Amizade amizade in lista)
            {
                if (nome.Equals(amizade.Nome))
                {
                    return true;
                }
            }
            return false;
        }
        public override string ToString()
        {
            return Nome + " : " + Email;
        }

        public override bool Equals(object obj)
        {
            return obj is Amizade amizade && Email == amizade.Email;
        }

    }
}
