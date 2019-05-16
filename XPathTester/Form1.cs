using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;

namespace XPathTester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTestXpath_Click(object sender, EventArgs e)
        {
            if (!IsValid())
            {
                return;
            }
            try
            {
                string xmlDocument = txtXmlDocument.Text;
                string xpathQuery = txtXPathQuery.Text;

                string formatedXmlDoc = PrettyXml(xmlDocument);
                txtXmlDocument.Text = formatedXmlDoc;

                using (var tr = new StringReader(xmlDocument))
                {
                    var doc = new XPathDocument(tr);

                    var navigator = doc.CreateNavigator();
                    navigator.Compile(xpathQuery);

                    var nodes = navigator.Select(xpathQuery);
                    int total = nodes.Count;

                    lblResultCount.Text = "Element found: " + total;

                    var resultText = new StringBuilder();

                    while (nodes.MoveNext())
                    {
                        resultText.Append(nodes.Current.OuterXml);
                        resultText.Append("\r\n");
                    }

                    txtXPathResult.Text = resultText.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("It's not a bug", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsValid()
        {
            string xpathQuery = txtXPathQuery.Text;
            string xmlDocument = txtXmlDocument.Text;

            string message = string.Empty;

            if (string.IsNullOrEmpty(xpathQuery))
            {
                message += "Please Input Xpath query\n";
            }

            if (string.IsNullOrEmpty(xmlDocument))
            {
                message += "Please Input XML document\n";
            }

            if (!string.IsNullOrEmpty(xmlDocument) && !ValidXmlString(xmlDocument))
            {
                message += "XML document is invalid format\n";
            }

            if (!string.IsNullOrEmpty(message))
            {
                MessageBox.Show(message);
            }

            return string.IsNullOrEmpty(message);
        }

        private bool ValidXmlString(string xmlDocument)
        {
            try
            {
                if (!string.IsNullOrEmpty(xmlDocument))
                {
                    var tr = new StringReader(xmlDocument);
                    var doc = new XPathDocument(tr); 
                    
                    return true;
                }

                return false;
            }
            catch (XmlException)
            {
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private string PrettyXml(string xml)
        {
            var stringBuilder = new StringBuilder();

            var doc = XElement.Parse(xml);

            var settings = new XmlWriterSettings
            {
                OmitXmlDeclaration = true,
                Indent = true,
                NewLineOnAttributes = false
            };

            using (var xmlWriter = XmlWriter.Create(stringBuilder, settings))
            {
                doc.Save(xmlWriter);
            }

            return stringBuilder.ToString();
        }

        private void btnClearQuery_Click(object sender, EventArgs e)
        {
            txtXPathQuery.Text = "";
        }
    }
}
