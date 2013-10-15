using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using L10NSharp;
using SampleApp.Properties;

namespace SampleApp
{
    public partial class SampleHTMLAppForm : Form
    {
        public SampleHTMLAppForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.ShowDialog();
            textBox1.Text = open.FileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HtmlToText converter = new HtmlToText();
            List<Node> list = converter.ConvertHtmlFile(textBox1.Text);
            foreach (var node in list)
                LocalizationManager.GetDynamicString("SampleHTMLAppId", node.node_hierarchy, node.content);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            L10NSharp.LocalizationManager.ShowLocalizationDialogBox("html");
        }

        private void uiLanguageComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Settings.Default.UserInterfaceLanguage = uiLanguageComboBox1.SelectedLanguage;
            LocalizationManager.SetUILanguage(uiLanguageComboBox1.SelectedLanguage, false);
            richTextBox1.Text = LocalizationManager.GetDynamicString("SampleHTMLAppId", "HTML.div1", "divvyy");
            foreach (Control control in this.Controls)
            {
                control.Text = LocalizationManager.GetDynamicString("SampleHTMLAppId", this.l10NSharpExtender1.GetLocalizingId(control), "error");
            }
        }
    }
}
