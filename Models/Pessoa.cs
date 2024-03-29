using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramExample.Models
{
    public class Pessoa
    {
        //Construtor
        public Pessoa(string nome, int idade, string cpf)
        {

            Nome = nome;
            Idade = idade;
            Cpf = cpf;

        }
        //Atributos privados
        private string _nome;
        private int _idade;
        private string _cpf;
        //Camada de encapsulamento
        public int Idade 
        { 
            get => _idade; 
            set
            {
             if(value > 0)
             {
                _idade = value;
             }   
            } 
            }
        public string Nome 
        { 
            get => _nome; 
            set
            {
                if(value != null && value.Length > 4)
                {
                    _nome = value;
                }
            } 
        }

        public string Cpf {
            get => _cpf;
            set{
                if (value.Length == 11)
                {
                    _cpf = value;
                }
            }
        }

        public void Apresentar(string nome)
        {
            Console.WriteLine($"Olá, eu me chamo {Nome} e sou cliente do banco");
        }

        public void Apresentar(string nome, string filial)
        {
            Console.WriteLine($"Olá, eu me chamo {Nome} e  sou gerente da filial {filial}");
        }

        public string GetNome()
        {
            return _nome;
        }
    }
}