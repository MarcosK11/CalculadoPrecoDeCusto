using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RetailApp.ViewModels.Fiscal;
using RetailApp.Utility;

namespace RetailApp.Desktop.UI
{
    public partial class DetalhesProdutoForm : Form
    {
        private det produto = default!;
        private int regime = default!;
        private ICMSTot ICMStot = default!;
        public DetalhesProdutoForm(det produtoNota,int Regime ,ICMSTot ICMSTot)
        {
            InitializeComponent();
            produto = Valida.validaDados(produtoNota);
            ICMStot = ICMSTot;
            regime = Regime;
            carregaDados(produto, ICMStot, regime);   
        }



        private void carregaDados(det produto, ICMSTot ICMStot,int regime)
        {
            Valida ICMS = new Valida();
            ICMS = ICMS.ValidaICMS(produto);

            //pegandos o dados para mostrar na tela
            vICMSDes.Text = ICMS.valorICMSDesonerado.ToString("0.00");
            vIPI.Text = produto.imposto.IPI.IPITrib.vIPI.ToString("0.00");
            vDifal.Text = produto.imposto.ICMSUFDest.vICMSUFDest.ToString("0.00");
            vFCPST.Text = ICMS.valorFCPST.ToString("0.00");
            Quantidade.Text = produto.prod.qTrib.ToString();
            vProd.Text = produto.prod.vProd.ToString("0.00");
            vICMSST.Text = ICMS.valorICMSST.ToString("0.00");

            //calculadora para o preço de custo
            vResult.Text = Calculadora.calculaPreco(produto, ICMStot, regime).ToString("0.00");

            //calculadora para ratear os custos entre os produtos
            vSeg.Text = Calculadora.calculaSeguro(produto, ICMStot).ToString("0.00");
            vDesp.Text = Calculadora.calculaDespesa(produto, ICMStot).ToString("0.00");
            vFrete.Text = Calculadora.calculaFrete(produto, ICMStot).ToString("0.00");


            //validação dos dados usados variando com o regime
            if (regime == 1 || regime == 2)
            {
                vICMS.Text = ICMS.valorICMS.ToString("0.00");
            }

            else if (regime == 3)
            {
                vICMS.Text = ICMS.valorICMS.ToString("0.00");
                vPIS.Text = produto.imposto.PIS.PISAliq.vPIS.ToString("0.00");
                vCofins.Text = produto.imposto.COFINS.COFINSAliq.vCOFINS.ToString("0.00");
            }
        }

        private void Recalc_Click(object sender, EventArgs e)
        {
            produto.prod.qTrib = decimal.Parse(Quantidade.Text);
            carregaDados(produto, ICMStot, regime);
        }
        private void Numerico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; // Ignora a tecla pressionada
            }

            // Permite apenas um ponto decimal
            if (e.KeyChar == '.' && ((TextBox)sender).Text.Contains('.'))
            {
                e.Handled = true; // Ignora a tecla pressionada
            }
        }
    }
}
