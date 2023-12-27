using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramExample.Models
{
    public class Pessoa
    {
        public Pessoa(string nome, int idade){

            Nome = nome;
            Idade = idade;

        }
        private string _nome;
        private int _idade;

        public int Idade { 
            get => _idade; 
            set{
             if(value > 0){
                _idade = value;
             }   
            } 
            }
        public string Nome { 
            get => _nome; 
            set{
                if(value != null && value.Length > 4){
                    _nome = value;
                }
            } 
        }

        public void Apresentar(){
            Console.WriteLine($"Aluno: {Nome} e {Idade}");
        }

    }
}