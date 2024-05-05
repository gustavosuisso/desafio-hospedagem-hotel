using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_hospedagem_hotel.Models
{
    public class Reserva
    {
        private List<Pessoa> _hospedes;
        public List<Pessoa> Hospedes { 
            
            get
            {
                return _hospedes;
            }
            set
            {

                if (value != null)
                {
                    _hospedes = value;
                }
               
            }

        }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva(int diasReservados)
        {
            this.DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {

            if (hospedes.Count <= Suite.Capacidade)
            {

                this.Hospedes = hospedes;
            
            }
            else
            {

                Console.WriteLine("Não foi possivel cadastrar, pois o número de hospedes excede a capacidade da suite.");

            }

        }

        public void CadastrarSuite(Suite suite)
        {

            this.Suite = suite;
           
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {

            if (DiasReservados >= 10)
            {
                decimal valor = this.Suite.ValorDiaria * DiasReservados;
                decimal desconto = valor * 0.10M; // adicionando os 10% de desconto
                return valor - desconto;
            }
            else
            {
                return this.Suite.ValorDiaria * DiasReservados;
            }
        }
    }
}