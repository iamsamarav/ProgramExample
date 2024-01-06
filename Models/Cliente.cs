using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProgramExample.Models;

namespace ProgramExample.Models
{
    public class Cliente : Pessoa
    {

        private Gerente Gerente { get; set; }

        public Cliente(Gerente gerente)
        {
            Gerente = gerente;

        }

        public void GetGerente()
        {
            Gerente.GetGerente(Gerente.GetNome());
        }
    }
}