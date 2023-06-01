using System;
using System.Windows.Forms;
using RetailApp.Utility;
using RetailApp.ViewModels.Fiscal;


namespace RetailApp.Desktop.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void NumberNFe_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void C_Click(object sender, EventArgs e)
        {

        }

        private void Button_Click(object sender, EventArgs e)
        {
            ImportXML();
        }

        private void ImportXML()
        {
            string xmlContent = FileUtility.GetStringFromXml();
            nfeProc nfeProc = XmlUtility.XmlToClass<nfeProc>(xmlContent);

            CarregaDados(nfeProc); //carrega os dados nos campos da tela
        }


        private void CarregaDados(nfeProc nfeProc)
        {
            //ajuste do campo data
            string dataCompleta = nfeProc.NFe.infNFe.ide.dhEmi;
            DateTime dataEmi = DateTime.Parse(dataCompleta);
            string dataFormatada = dataEmi.ToString("yyyy-MM-dd");

            //ajuste chave de acesso NFe
            string chaveAcesso = nfeProc.NFe.infNFe.Id;
            string chaveNumerica = chaveAcesso.Substring(3);

            NumberNFe.Text = nfeProc.NFe.infNFe.ide.nNF;
            Date.Text = dataFormatada;
            Chave.Text = chaveNumerica;
        }
    }
}
