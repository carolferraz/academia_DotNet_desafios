﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmigoSecreto
{
    internal class Amigo
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public Amigo(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }
    }
}
