using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafioEstacionamento.Models
{
    public class Estacionamento
    {
        private decimal precoInit = 0;
        private decimal precoPerHour = 0;
        private List<string> veiculos = new List<string>();
        public Estacionamento(decimal pi, decimal ph) {
        precoInit = pi;
        precoPerHour = ph;


        }

        public void addVeiculo() {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string p = Console.ReadLine();
            if(veiculos.Contains(p)) {
                Console.WriteLine("Veículo já estacionado!");
            } else {
                veiculos.Add(p);
            }
        }

        public void removeVeiculo() {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine();

            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                int horas = int.Parse(Console.ReadLine());
                decimal valorTotal = precoInit + precoPerHour * horas; 
                veiculos.Remove(placa);
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach (string item in veiculos)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }


    }
}