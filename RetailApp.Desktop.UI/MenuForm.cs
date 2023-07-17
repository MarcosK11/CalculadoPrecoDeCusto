using System;
using System.Windows.Forms;
using RetailApp.Utility;
using RetailApp.ViewModels.Fiscal;
using RetailApp.Desktop.UI;
namespace RetailApp.Desktop.UI
{
    public partial class Menu : Form
    {
        private nfeProc nfeProc = default!;
        public Menu()
        {
            InitializeComponent();

            //valor padrão pro regime tributario
            regimeTrib.SelectedIndex = 0;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            try{
                ImportXML();
                }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao importar o XML: " + ex.Message + "\nTente Novamente!");
            }
        }

        private void ImportXML()
        {
            string xmlContent = FileUtility.GetStringFromXml();
            nfeProc = XmlUtility.XmlToClass<nfeProc>(xmlContent);

            //carrega os dados nos campos da tela
            CarregaDados(nfeProc); 

            //ativando os botões e campos apos importar a XML
            Recalc.Enabled = true;
            Despesa.Enabled = true;
            Seguro.Enabled = true;
            Frete.Enabled = true;
        }


        private void CarregaDados(nfeProc nfeProc)
        {
            Despesa.Text = nfeProc.NFe.infNFe.total.ICMSTot.vOutro.ToString("0.00");
            Seguro.Text = nfeProc.NFe.infNFe.total.ICMSTot.vSeg.ToString("0.00");
            Frete.Text = nfeProc.NFe.infNFe.total.ICMSTot.vFrete.ToString("0.00");

            listView1.Items.Clear();
            
            // Percorra a lista 'det' e adicione cada item como uma linha no ListView
            foreach (var item in nfeProc.NFe.infNFe.det)
            {
                det ProdutoValidado = Valida.validaDados(item);

                // Crie uma nova ListViewItem para representar o item na lista
                ListViewItem listViewItem = new ListViewItem(item.nItem.ToString());
                listViewItem.SubItems.Add(item.prod.cProd);
                listViewItem.SubItems.Add(item.prod.xProd);
                listViewItem.SubItems.Add(item.prod.qCom.ToString());
                listViewItem.SubItems.Add(Calculadora.calculaPreco(ProdutoValidado, nfeProc.NFe.infNFe.total.ICMSTot, regimeTrib.SelectedIndex).ToString("0.00"));
                listView1.Items.Add(listViewItem);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verifique se algum item está selecionado
            if (listView1.SelectedItems.Count > 0)
            {
                // Obtenha o item selecionado
                ListViewItem selectedItem = listView1.SelectedItems[0];
                int indice = selectedItem.Index;
                det itemSelecionado = nfeProc.NFe.infNFe.det[indice];
                ICMSTot ICMStot = nfeProc.NFe.infNFe.total.ICMSTot;
                int regimeSelecionado = regimeTrib.SelectedIndex;

                // Crie uma instância do DetalhesProdutoForm
                DetalhesProdutoForm detalhesForm = new DetalhesProdutoForm(itemSelecionado, regimeSelecionado ,ICMStot);

                // Exiba o formulário de detalhes do produto
                detalhesForm.ShowDialog();
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        //botão Recalcular, quando clicar nele, vai recarregar os dados em dela
        private void Recalc_Click(object sender, EventArgs e)
        {
            nfeProc.NFe.infNFe.total.ICMSTot.vFrete = decimal.Parse(Frete.Text);
            nfeProc.NFe.infNFe.total.ICMSTot.vOutro = decimal.Parse(Despesa.Text);
            nfeProc.NFe.infNFe.total.ICMSTot.vSeg = decimal.Parse(Seguro.Text);
            CarregaDados(nfeProc);
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
