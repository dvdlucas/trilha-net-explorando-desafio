using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Models
{
    internal class Reserva
    {
        public IList<Pessoa> Hospedes;
        public int DiasReservados { get; set; }
        public Suite Suite { get; private set; }

        public Reserva() { }
        public Reserva(int diasReservados)
        {
            diasReservados = DiasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {

            int qtdCapacidade = Suite.Capacidade;
            if ( qtdCapacidade >= hospedes.Count )
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception("Essa suite não comporta esse tanto de gente");
            }
        }

        public void CadastrarSuite(Suite suite) { Suite = suite; }

        public int ObterQuantidadesHospedes()
        {
            int qtdHospedes = Hospedes.Count;
            return qtdHospedes;
        }

        public decimal CalcularValorDiaria()
        {
            decimal valortotal = DiasReservados * Suite.ValorDiaria;

            if (DiasReservados > 10)
            {
                decimal valorCDesconto = valortotal - (valortotal * 10 / 100);
                return valorCDesconto;
            } else
            {
                return valortotal;
            }
        }
        public string NomesPessoas()
        {
            if (Hospedes.Count > 0)
            {
                StringBuilder pessoas = new StringBuilder();

                foreach (Pessoa pessoa in Hospedes)
                {
                    pessoas.Append(pessoa.Nome + " , ");
                }

                if (pessoas.Length > 0)
                {
                    pessoas.Length--;
                }

                return pessoas.ToString();
            }
            return "Não tem hospedes";
        }

    }
}
