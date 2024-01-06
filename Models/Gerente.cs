using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProgramExample.Models;

namespace ProgramExample.Models
{
   public class Gerente : Pessoa
   {
      private decimal Salario { get; set; }

        public Gerente(string nome, int idade, string cpf, decimal salario) : base(nome, idade, cpf){
            Salario = salario;
        }

        public void ExibirSalario(decimal Salario){
            Console.WriteLine($"Seu salário por padrão é {Salario}");
        }

        public void RelatorioFilial(string filial){
            //implementar o retorno da quantidade de clientes
            Console.WriteLine("O banco possui");
        }
        //Verificar esse get
        public void GetGerente(string nome){
            Console.WriteLine($"Gerente {nome}");
        }
   }
}
