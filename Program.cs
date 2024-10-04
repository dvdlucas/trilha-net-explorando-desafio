using Hotel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa("David", "Lucas");
            Pessoa p2 = new Pessoa("Neymar", "Junior");
            Pessoa p3 = new Pessoa("Lionel", "Messi");

            List<Pessoa> pessoas = new List<Pessoa>();
            pessoas.Add(p1);
            pessoas.Add(p2);
            pessoas.Add(p3);

            Suite suite = new Suite("Premium", 3, 375);

            Reserva reserva = new Reserva();
            reserva.CadastrarSuite(suite);
            reserva.CadastrarHospedes(pessoas);
            reserva.DiasReservados = 10;
            Console.WriteLine("Total Hospedes : " + reserva.ObterQuantidadesHospedes());
            Console.WriteLine("Reserva de : ");
            Console.WriteLine(reserva.NomesPessoas());
            Console.WriteLine(" ficou o total de R$ " + reserva.CalcularValorDiaria());
        }
    }
}
