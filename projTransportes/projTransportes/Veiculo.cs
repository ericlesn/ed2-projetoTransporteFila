using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projTransportes
{
    class Veiculo
    {
        private string placa;
        private string motorista;
        private int lotacao;
        private int lugares;
        private double valor;

        private Viagem viagem;

        public override string ToString()
        {
            string espaco = new string(' ', 5);
            return Placa + espaco + Motorista + espaco + Lotacao.ToString("D2");
        }
        public Veiculo() : this("", "", 0)
        {

        }
        public Veiculo(string pPlaca, string pMotorista, int pLotacao)
        {
            placa = pPlaca;
            motorista = pMotorista;
            lotacao = pLotacao;
            lugares = 0;
            viagem = new Viagem(this, DateTime.Now);
        }
        public string Placa
        {
            get
            {
                return placa;
            }

            set
            {
                placa = value;
            }
        }

        public string Motorista
        {
            get
            {
                return motorista;
            }

            set
            {
                motorista = value;
            }
        }

        public int Lotacao
        {
            get
            {
                return lotacao;
            }

            set
            {
                lotacao = value;
            }
        }

        public Viagem Viagem
        {
            get
            {
                return viagem;
            }

            set
            {
                viagem = value;
            }
        }

        public double Valor
        {
            get
            {
                return valor;
            }

            set
            {
                valor = value;
            }
        }

        public int Lugares
        {
            get
            {
                return lugares;
            }

            set
            {
                lugares = value;
                valor = (double)value * 5;
            }
        }

    }
}
