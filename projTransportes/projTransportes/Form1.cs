using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projTransportes
{
    public partial class Form1 : Form
    {
        private List<Veiculo> veiculos;
        private List<Visitante> visitantes;
        private Queue<Visitante> passageiros;
        private List<Viagem> viagens;
        
        public Form1()
        {
            InitializeComponent();
            Veiculos = new List<Veiculo>();
            Visitantes = new List<Visitante>();
            passageiros = new Queue<Visitante>();
            Visitantes = new List<Visitante>();
            
        }
        internal List<Veiculo> Veiculos
        {
            get
            {
                return veiculos;
            }

            set
            {
                veiculos = value;
            }
        }

        internal List<Visitante> Visitantes
        {
            get
            {
                return visitantes;
            }

            set
            {
                visitantes = value;
            }
        }

        internal List<Viagem> Viagens
        {
            get
            {
                return viagens;
            }

            set
            {
                viagens = value;
            }
        }

        private void btn_AddCarro_Click(object sender, EventArgs e)
        {
            Veiculo fVeiculo = new Veiculo();

            fVeiculo.Placa = txtPlaca.Text.Trim();
            fVeiculo.Motorista = txtMotorista.Text.Trim();
            fVeiculo.Lotacao = int.Parse(txtLotacao.Text.Trim());

            LimpaFormVeiculo();

            Veiculos.Add(fVeiculo);
            listarVeiculos.DataSource = null;
            listarVeiculos.DataSource = Veiculos;
            Viagem fViagem = new Viagem(fVeiculo, DateTime.Now);
            if (Viagens.Count > 0)
            {
                fViagem.Entrada = Viagens[Viagens.Count - 1].Saida;
            }
            else
            {
                fViagem.Entrada = fViagem.Entrada.AddMinutes(30);
            }
            Viagens.Add(fViagem);

            fVeiculo.Viagem = fViagem;
        }
        private void LimpaFormVeiculo()
        {
            txtPlaca.Clear();
            txtMotorista.Clear();
            txtLotacao.Clear();
        }
        private void LimpaFormVisitante()
        {
            txtInscricao.Clear();
            txtNome.Clear();
        }
        private void RecalcularSaidas(DateTime pSaida)
        {
            for (int i = 1; i < Viagens.Count; i++)
            {
                if (Viagens[i].Passageiros.Count < Viagens[i].Carro.Lotacao)
                {
                    Viagens[i].Entrada = Viagens[i - 1].Saida;
                }

            }
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            bool temCarro = false;
            Visitante iVisitante = new Visitante();
            iVisitante.Inscricao = txtInscricao.Text.Trim();
            iVisitante.Nome = txtNome.Text.Trim();

            Visitantes.Add(iVisitante);
            listarVisitantes.DataSource = null;
            listarVisitantes.DataSource = Visitantes;

            LimpaFormVisitante();

            foreach (Viagem fViagem in Viagens)
            {

                if (fViagem.Passageiros.Count < fViagem.Carro.Lotacao && fViagem.Entrada < fViagem.Entrada.AddMinutes(30))
                {
                    fViagem.Passageiros.Add(iVisitante);
                    fViagem.Carro.Lugares++;
                    temCarro = true;

                    if (fViagem.Carro.Lotacao == fViagem.Passageiros.Count)
                    {
                        fViagem.Saida = DateTime.Now;
                        RecalcularSaidas(fViagem.Saida);
                    }
                    AtualizaInfo();
                    return;
                }
                else if (fViagem.Entrada.AddMinutes(30) < DateTime.Now)
                {
                    fViagem.Saida = fViagem.Entrada.AddMinutes(30);
                }
            }


            if (!temCarro)
            {
                MessageBox.Show("Veículos indisponíveis", "Nenhum veículo disponível", MessageBoxButtons.OK);
            }
        }
        private void AtualizaInfo()
        {
            if (listarVeiculos.SelectedIndex > -1)
            {
                lblLotacaoTotal.Text = "Lotação: " + Veiculos[listarVeiculos.SelectedIndex].Lotacao.ToString();
                lblAssentosLivres.Text = "Quantidade assentos livres: " + (Veiculos[listarVeiculos.SelectedIndex].Lotacao - Veiculos[listarVeiculos.SelectedIndex].Viagem.Passageiros.Count).ToString();
                lblPrevisaoSaida.Text = "Saída: " + Veiculos[listarVeiculos.SelectedIndex].Viagem.Saida.ToString();
                lblValor.Text = "A receber: R$ " + string.Format("{0:0.00}", Veiculos[listarVeiculos.SelectedIndex].Valor);
            }
            else
            {
                lblLotacaoTotal.Text = "Lotação: ??";
                lblAssentosLivres.Text = "Quantidade assentos livres: ??";
                lblPrevisaoSaida.Text = "Saída: ??";
                lblValor.Text = "A receber: R$ ??,??";
            }

        }
        private void lstVeiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizaInfo();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LimpaFormVeiculo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LimpaFormVisitante();
        }

    }
}


