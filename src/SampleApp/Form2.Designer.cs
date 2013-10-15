namespace SampleApp
{
    partial class SampleHTMLAppForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.uiLanguageComboBox1 = new L10NSharp.UI.UILanguageComboBox();
            this.l10NSharpExtender1 = new L10NSharp.UI.L10NSharpExtender(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.l10NSharpExtender1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.l10NSharpExtender1.SetLocalizableToolTip(this.textBox1, null);
            this.l10NSharpExtender1.SetLocalizationComment(this.textBox1, null);
            this.l10NSharpExtender1.SetLocalizingId(this.textBox1, "SampleHTMLAppForm.textBox1");
            this.textBox1.Location = new System.Drawing.Point(12, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Text = "P:\\cos350\\index.html";
            this.textBox1.Size = new System.Drawing.Size(179, 20);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.l10NSharpExtender1.SetLocalizableToolTip(this.button1, null);
            this.l10NSharpExtender1.SetLocalizationComment(this.button1, null);
            this.l10NSharpExtender1.SetLocalizingId(this.button1, "SampleHTMLAppForm.button1");
            this.button1.Location = new System.Drawing.Point(197, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Load HTML";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.l10NSharpExtender1.SetLocalizableToolTip(this.button2, null);
            this.l10NSharpExtender1.SetLocalizationComment(this.button2, null);
            this.l10NSharpExtender1.SetLocalizingId(this.button2, "SampleHTMLAppForm.button2");
            this.button2.Location = new System.Drawing.Point(197, 61);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Parse";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 90);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(260, 160);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // button3
            // 
            this.l10NSharpExtender1.SetLocalizableToolTip(this.button3, null);
            this.l10NSharpExtender1.SetLocalizationComment(this.button3, null);
            this.l10NSharpExtender1.SetLocalizingId(this.button3, "SampleHTMLAppForm.button3");
            this.button3.Location = new System.Drawing.Point(12, 61);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(179, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Open Localizer";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // uiLanguageComboBox1
            // 
            this.uiLanguageComboBox1.DisplayMember = "NativeName";
            this.uiLanguageComboBox1.DropDownHeight = 200;
            this.uiLanguageComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uiLanguageComboBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.uiLanguageComboBox1.FormattingEnabled = true;
            this.uiLanguageComboBox1.IntegralHeight = false;
            this.l10NSharpExtender1.SetLocalizableToolTip(this.uiLanguageComboBox1, null);
            this.l10NSharpExtender1.SetLocalizationComment(this.uiLanguageComboBox1, null);
            this.l10NSharpExtender1.SetLocalizingId(this.uiLanguageComboBox1, "SampleHTMLAppForm.uiLanguageComboBox1");
            this.uiLanguageComboBox1.Location = new System.Drawing.Point(12, 5);
            this.uiLanguageComboBox1.Name = "uiLanguageComboBox1";
            this.uiLanguageComboBox1.Size = new System.Drawing.Size(179, 23);
            this.uiLanguageComboBox1.TabIndex = 6;
            this.uiLanguageComboBox1.SelectedIndexChanged += new System.EventHandler(this.uiLanguageComboBox1_SelectedIndexChanged);
            // 
            // l10NSharpExtender1
            // 
            this.l10NSharpExtender1.LocalizationManagerId = "SampleHTMLApp";
            this.l10NSharpExtender1.PrefixForNewItems = "";
            // 
            // SampleHTMLAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.uiLanguageComboBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.l10NSharpExtender1.SetLocalizableToolTip(this, null);
            this.l10NSharpExtender1.SetLocalizationComment(this, null);
            this.l10NSharpExtender1.SetLocalizingId(this, "SampleHTMLAppForm.WindowTitle");
            this.Name = "SampleHTMLAppForm";
            this.Text = "SampleHTMLForm";
            ((System.ComponentModel.ISupportInitialize)(this.l10NSharpExtender1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button3;
        private L10NSharp.UI.UILanguageComboBox uiLanguageComboBox1;
        private L10NSharp.UI.L10NSharpExtender l10NSharpExtender1;

    }
}