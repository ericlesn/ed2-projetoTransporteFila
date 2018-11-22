using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projTransportes
{
    class Viagem
    {
        private Veiculo carro;
        private List<Visitante> passageiros;
        private DateTime entrada;
        private DateTime saida;

        public Viagem(Veiculo pCarro, DateTime pEntrada)
        {
            Carro = pCarro;
            Entrada = pEntrada;
            Passageiros = new List<Visitante>();
        }

        public DateTime Saida
        {
            get
            {
                return saida;
            }

            set
            {
                saida = value;
            }
        }

        public Veiculo Carro
        {
            get
            {
                return carro;
            }

            set
            {
                carro = value;
            }
        }

        public List<Visitante> Passageiros
        {
            get
            {
                return passageiros;
            }

            set
            {
                passageiros = value;
            }
        }

        public DateTime Entrada
        {
            get
            {
                return entrada;
            }

            set
            {
                entrada = value;
                saida = value.AddMinutes(30);
            }
        }

    }
}
