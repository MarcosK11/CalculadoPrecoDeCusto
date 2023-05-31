using RetailApp.Utility;
using RetailApp.ViewModels;
using System;
using System.Windows.Forms;



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
        }
    }
}
