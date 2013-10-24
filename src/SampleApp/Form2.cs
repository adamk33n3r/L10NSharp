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
using HtmlAgilityPack;
using System.IO;

namespace SampleApp
{
    public partial class SampleHTMLAppForm : Form
    {
        public SampleHTMLAppForm()
        {
            InitializeComponent();
            LocalizationManager.SetUILanguage("es", false);
            Console.WriteLine("HtmlString: "+LocalizationManager.LocalizeHtmlString("<h1>hello there</h1>", "html-s-1", "SampleHTMLAppId"));
        }

        // Load Html
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.ShowDialog();
            textBox1.Text = open.FileName;
        }

        // Parse
        private void button2_Click(object sender, EventArgs e)
        {
            LocalizationManager.LocalizeHtmlFile(this.textBox1.Text, "SampleHTMLAppId");
            StreamReader file = new StreamReader(this.textBox1.Text);
            var html = file.ReadToEnd();
            file.Close();
            richTextBox1.Text = html;
        }

        // Open Localization Dialog
        private void button3_Click(object sender, EventArgs e)
        {
            L10NSharp.LocalizationManager.ShowLocalizationDialogBox("html");
        }

        private void uiLanguageComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Settings.Default.UserInterfaceLanguage = uiLanguageComboBox1.SelectedLanguage;
            LocalizationManager.SetUILanguage(uiLanguageComboBox1.SelectedLanguage, false);
            foreach (Control control in this.Controls)
            {
                control.Text = LocalizationManager.GetDynamicString("SampleHTMLAppId", this.l10NSharpExtender1.GetLocalizingId(control), "error");
            }
            
            var path_to_localized_html = LocalizationManager.LocalizeHtmlFile(this.textBox1.Text, "SampleHTMLAppId");

            StreamReader file = new StreamReader(path_to_localized_html);
            var html = file.ReadToEnd();
            file.Close();
            richTextBox1.Text = html;
            textBox1.Text = path_to_localized_html;
            Console.WriteLine("HtmlString: " + LocalizationManager.LocalizeHtmlString("<h1>hello there</h1>", "html-s-1", "SampleHTMLAppId"));
        }
    }
}
