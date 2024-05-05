using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace desafio_hospedagem_hotel.Models
{
    public class Pessoa
    {

        private string _nome;
        private string _sobrenome;

        public string Nome {

            get 
            {
                return _nome;
            }
            
            set {

                if (value != null && value != "")
                {
                    this._nome = value;
                }
            } 
            
        }
        public string Sobrenome {
            
             get
             {
                return _sobrenome;
             } 
             
             set
             {
                if( value != null && value != "")
                {
                    this._sobrenome = value;
                }
             } 
             
        }

        public Pessoa (string nome, string sobrenome)
        {
            this.Nome = nome;
            this.Sobrenome = sobrenome;
        }        
    }
}