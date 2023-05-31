using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailApp.Utility
{
    public class FileUtility
    {
        public static string GetStringFromXml()
        {
            string xmlString = string.Empty;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = false;
            openFileDialog.Filter = "XML FILES(*xml)|*.xml|All files(*.*)|*.*\";";

        DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                using(StreamReader streamReader = new StreamReader(openFileDialog.FileName))
                {
                    xmlString = streamReader.ReadToEnd();
                }
            }

            return xmlString;
        }
    }
}
