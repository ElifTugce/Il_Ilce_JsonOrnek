
using System;

namespace Il_Ilce_JsonOrnek
{
    partial class FormILSorgulama
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxILSecimi = new System.Windows.Forms.ComboBox();
            this.btnSec = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.detayGosterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxIL = new System.Windows.Forms.GroupBox();
            this.richTextBoxIL = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBoxIL.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "İL ADI:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBoxILSecimi
            // 
            this.comboBoxILSecimi.FormattingEnabled = true;
            this.comboBoxILSecimi.Location = new System.Drawing.Point(101, 32);
            this.comboBoxILSecimi.Name = "comboBoxILSecimi";
            this.comboBoxILSecimi.Size = new System.Drawing.Size(532, 28);
            this.comboBoxILSecimi.TabIndex = 1;
            // 
            // btnSec
            // 
            this.btnSec.Location = new System.Drawing.Point(646, 31);
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(117, 29);
            this.btnSec.TabIndex = 2;
            this.btnSec.Text = "SEÇ";
            this.btnSec.UseVisualStyleBackColor = true;
            this.btnSec.Click += new System.EventHandler(this.btnSec_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(28, 81);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(605, 306);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "İsim";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Telefon";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Fax";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Eposta";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Web Sitesi";
            this.columnHeader5.Width = 100;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detayGosterToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(165, 28);
            // 
            // detayGosterToolStripMenuItem
            // 
            this.detayGosterToolStripMenuItem.Name = "detayGosterToolStripMenuItem";
            this.detayGosterToolStripMenuItem.Size = new System.Drawing.Size(164, 24);
            this.detayGosterToolStripMenuItem.Text = "Detay Göster";
            this.detayGosterToolStripMenuItem.Click += new System.EventHandler(this.detayGosterToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "İl Hakkında Bilgiler:";
            // 
            // groupBoxIL
            // 
            this.groupBoxIL.Controls.Add(this.richTextBoxIL);
            this.groupBoxIL.Controls.Add(this.label2);
            this.groupBoxIL.Location = new System.Drawing.Point(646, 66);
            this.groupBoxIL.Name = "groupBoxIL";
            this.groupBoxIL.Size = new System.Drawing.Size(263, 337);
            this.groupBoxIL.TabIndex = 6;
            this.groupBoxIL.TabStop = false;
            this.groupBoxIL.Text = "groupBox1";
            // 
            // richTextBoxIL
            // 
            this.richTextBoxIL.Location = new System.Drawing.Point(18, 46);
            this.richTextBoxIL.Name = "richTextBoxIL";
            this.richTextBoxIL.ReadOnly = true;
            this.richTextBoxIL.Size = new System.Drawing.Size(216, 269);
            this.richTextBoxIL.TabIndex = 5;
            this.richTextBoxIL.Text = "";
            // 
            // FormILSorgulama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(925, 427);
            this.Controls.Add(this.groupBoxIL);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnSec);
            this.Controls.Add(this.comboBoxILSecimi);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "FormILSorgulama";
            this.Text = "FormILSorgulama";
            this.Load += new System.EventHandler(this.FormILSorgulama_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBoxIL.ResumeLayout(false);
            this.groupBoxIL.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxILSecimi;
        private System.Windows.Forms.Button btnSec;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxIL;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem detayGosterToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBoxIL;
    }
}