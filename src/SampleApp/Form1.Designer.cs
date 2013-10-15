namespace SampleApp
{
    partial class Form1
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
            this._getDynamicStringButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.uiLanguageComboBox1 = new L10NSharp.UI.UILanguageComboBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // _getDynamicStringButton
            // 
            this._getDynamicStringButton.Location = new System.Drawing.Point(38, 161);
            this._getDynamicStringButton.Name = "_getDynamicStringButton";
            this._getDynamicStringButton.Size = new System.Drawing.Size(126, 23);
            this._getDynamicStringButton.TabIndex = 0;
            this._getDynamicStringButton.Text = "Get Name Dynamically";
            this._getDynamicStringButton.UseVisualStyleBackColor = true;
            this._getDynamicStringButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "A Static Label";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "or Shift-Ctrl Click on items to localize them";
            // 
            // uiLanguageComboBox1
            // 
            this.uiLanguageComboBox1.DisplayMember = "NativeName";
            this.uiLanguageComboBox1.DropDownHeight = 200;
            this.uiLanguageComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uiLanguageComboBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.uiLanguageComboBox1.FormattingEnabled = true;
            this.uiLanguageComboBox1.IntegralHeight = false;
            this.uiLanguageComboBox1.Location = new System.Drawing.Point(40, 41);
            this.uiLanguageComboBox1.Name = "uiLanguageComboBox1";
            this.uiLanguageComboBox1.ShowOnlyLanguagesHavingLocalizations = true;
            this.uiLanguageComboBox1.Size = new System.Drawing.Size(121, 23);
            this.uiLanguageComboBox1.TabIndex = 3;
            this.uiLanguageComboBox1.SelectedIndexChanged += new System.EventHandler(this.uiLanguageComboBox1_SelectedIndexChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(40, 88);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(124, 13);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Open Translation Dialog,";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "One";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Two";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.Location = new System.Drawing.Point(28, 280);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(338, 97);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 436);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.uiLanguageComboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._getDynamicStringButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Localization Sample App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _getDynamicStringButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private L10NSharp.UI.UILanguageComboBox uiLanguageComboBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}

