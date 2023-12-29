using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafioCelular.Models
{
    public abstract class Smartphone
    {
        public string numero {get; set;}
        private string modelo;
        private string imei;
        private int memoria;

        public Smartphone(string numero, string modelo, string imei, int memoria) {
            this.numero = numero;   
            this.modelo = modelo;
            this.imei = imei;
            this.memoria = memoria;
        }

        public void ligar() {
            Console.WriteLine("Ligando...");
        }

        public void receberLigacao() {
            Console.WriteLine("Recebendo ligação...");
        }

        public void exibirInfos() {
            Console.WriteLine($"Número: {numero} \n Modelo: {modelo} \n IMEI: {imei} \n Memoria: {memoria}");
        }

        public abstract void installApp(string nome);
    }
}