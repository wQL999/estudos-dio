using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafioCelular.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public override void installApp(string nome)
        {
             System.Console.WriteLine($"Instalando {nome} no celular Iphone.");
        }
    }
}