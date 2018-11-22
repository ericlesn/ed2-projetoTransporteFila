using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projTransportes
{
    class Visitante
    {
        private string inscricao;
        private string nome;

        public override string ToString()
        {
            string espaco = new string(' ', 5);
            return Inscricao + espaco + Nome;
        }

        public Visitante(string pInscricao, string pNome)
        {
            inscricao = pInscricao;
            nome = pNome;
        }

        public Visitante() : this("", "")
        {

        }

        public string Inscricao
        {
            get
            {
                return inscricao;
            }

            set
            {
                inscricao = value;
            }
        }

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

    }
}
