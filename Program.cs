using System.Text;
using desafio_hospedagem_hotel.Models;


List<Pessoa> hospedes = new List<Pessoa>();

// criando duas referências que irão apontar para os respectivos objetos da classe Pessoa
Pessoa p1 = new Pessoa(nome: "Gustavo", sobrenome: "Suisso");
Pessoa p2 = new Pessoa("Henrique", "Barreto");

// adicionando as duas pessoas na lista de hospedes
hospedes.Add(p1);
hospedes.Add(p2);

// criando a suite
Suite suite = new Suite(tipoSuite:"Premium", capacidade: 2, valorDiaria: 20);

// criando uma reserva e adicionando os hospedes e a suite
Reserva reserva = new Reserva(diasReservados: 11);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// exibindo a quantidade de hospedes e o valor da diária:
Console.WriteLine($"Quantidade de hospedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor da diária: {reserva.CalcularValorDiaria()}");






