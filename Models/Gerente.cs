using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramExample.Models
{
   public class Gerente : Pessoa
   {
      private decimal Salario { get; set; }
      
        public Gerente(string nome, int idade, string cpf, decimal salario) : base(nome, idade, cpf){
            Salario = salario;
        }
   }
}
